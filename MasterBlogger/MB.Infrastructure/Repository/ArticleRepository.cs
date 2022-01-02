﻿using AutoMapper;
using MB.Application.Contracts.Article;
using MB.Domain.Models.ArticleAgg;
using MB.Domain.Models.ArticleAgg.Exceptions;
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
            Validation(article.Title, article.CategoryID);
              _mBContext.Articles.Add(article);
                SaveChanges();
           
        }
        public void Validation(string title, long categoryID)
        {
            if (string.IsNullOrEmpty(title))
                throw new EmptyStringException("خطای رشته خالی");
            if (categoryID == 0)
                throw new CategoryIDEqualtoZero("شناسه دسته نباید صفر باشد");
            if (Exist(title))
                throw new DuplicatedRecordException("این دسته قبلاْ ایجاد شده است.");
        }

        public void Delete(long articleID)
        {
            _mBContext.Articles.FirstOrDefault(x => x.ArticleID == articleID).IsDeleted=true;
            SaveChanges();
        }
        public void Restore(long articleID)
        {
            _mBContext.Articles.FirstOrDefault(x => x.ArticleID == articleID).IsDeleted = false;
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
               CategoryTitle=x.ArticleCategory.Title
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
                    CategoryTitle = x.ArticleCategory.Title
                }).FirstOrDefault(x => x.ArticleID == articleID);
        }

      

        public void SaveChanges()
        {
            _mBContext.SaveChanges();
        }

        public void Update(EditArticleCommand editedArticle)
        {
            var article=_mBContext.Articles.FirstOrDefault(x=>x.ArticleID==editedArticle.ArticleID);
            article.Title = editedArticle.Title;
            article.ShortDESC = editedArticle.ShortDESC;
            article.Body = editedArticle.Body;
            article.PicTitle = editedArticle.PicTitle;
            article.PicALT = editedArticle.PicALT;
            article.PicSrc = editedArticle.PicSrc;
            article.CategoryID = editedArticle.CategoryID;
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

        public bool Exist(string Title)
        { 
          return _mBContext.Articles.Any(x => x.Title == Title);  
        }

        public List<ArticleViewModel> GetLast(int number)
        {
            return _mBContext.Articles.Include(x => x.ArticleCategory)
                .OrderByDescending(x => x.ArticleID).Take(number).Select(x => new ArticleViewModel
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
                    CategoryTitle = x.ArticleCategory.Title
                }).ToList();
        }
    }
}
