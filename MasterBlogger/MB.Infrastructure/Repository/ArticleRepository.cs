﻿using MB.Application.Contracts.Article;
using MB.Domain.Models.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MBContext _mBContext;

        public ArticleRepository(MBContext mBContext)
        {
            _mBContext = mBContext;
        }

        public void Create(Article article)
        {
            _mBContext.Articles.Add(article);
            SaveChanges();

        }

        public void Delete(long articleID)
        {
            var article = GetBy(articleID);
            article.IsDeleted = true;
            SaveChanges();
        }
        public void Restore(long articleID)
        {
            var article = GetBy(articleID);
            article.IsDeleted = false;
            SaveChanges();
        }

        public List<ArticleViewModel> GetAll()
        {

            return _mBContext.Articles.Include(x=>x.ArticleCategory)
                .OrderByDescending(x => x.ArticleID).Select(x=>new ArticleViewModel
            {   ArticleID = x.ArticleID,
                Title = x.Title,
                ShortDESC=x.ShortDESC,
                Body = x.Body,
                PicTitle=x.PicTitle,
                PicALT=x.PicALT,
                PicSrc=x.PicSrc,
                IsDeleted=x.IsDeleted,
                CreationDate=x.CreationDate.ToString(),
               ArticleCategory=x.ArticleCategory.Title
            }).ToList();
        }

        public ArticleViewModel GetBy(long articleID)
        {
            return _mBContext.Articles.Include(x => x.ArticleCategory)
                .OrderByDescending(x => x.ArticleID).Select(x => new ArticleViewModel
                {
                    ArticleID = x.ArticleID,
                    Title = x.Title,
                    ShortDESC = x.ShortDESC,
                    Body = x.Body,
                    PicTitle = x.PicTitle,
                    PicALT = x.PicALT,
                    PicSrc = x.PicSrc,
                    IsDeleted = x.IsDeleted,
                    CreationDate = x.CreationDate.ToString(),
                    ArticleCategory = x.ArticleCategory.Title
                }).FirstOrDefault(x => x.ArticleID == articleID);
        }

      

        public void SaveChanges()
        {
            _mBContext.SaveChanges();
        }

        public void Update(EditArticleCommand article)
        {
            var articleForEdit=_mBContext.Articles.FirstOrDefault(x=>x.ArticleID==article.ArticleID);
            articleForEdit.Title = article.Title;
            articleForEdit.ShortDESC = article.ShortDESC;
            articleForEdit.Body = article.Body;
            articleForEdit.PicTitle = article.PicTitle;
            articleForEdit.PicALT = article.PicALT;
            articleForEdit.PicSrc = article.PicSrc;
            articleForEdit.CategoryID = article.CategoryID;
            SaveChanges();
        }

        public EditArticleCommand GetDetails(long articleID)
        {
            return _mBContext.Articles.Include(x => x.ArticleCategory)
                .OrderByDescending(x => x.ArticleID).Select(x => new EditArticleCommand
                {
                    ArticleID = x.ArticleID,
                    Title = x.Title,
                    ShortDESC = x.ShortDESC,
                    Body = x.Body,
                    PicTitle = x.PicTitle,
                    PicALT = x.PicALT,
                    PicSrc = x.PicSrc,
                    CategoryID = x.ArticleCategory.CategoryID
                }).FirstOrDefault(x => x.ArticleID == articleID);
        }
    }
}
