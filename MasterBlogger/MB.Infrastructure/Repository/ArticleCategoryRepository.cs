using MB.Application.Contracts.ArticleCategory;
using MB.Domain.Model.ArticleCategoryAgg;
using MB.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Repository
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MBContext mbContext;

        public ArticleCategoryRepository(MBContext mbContext)
        {
            this.mbContext = mbContext;
        }

        public void Create(ArticleCategory articleCaregory)
        {
            mbContext.ArticleCategories.Add(articleCaregory);
            mbContext.SaveChanges();
        }

        public void Delete(int categoryID)
        {
            throw new NotImplementedException();
        }

        public List<ArticleCategoryViewModel> GetAll()
        {
            return mbContext.ArticleCategories.OrderByDescending(x=>x.CategoryID).Select(x=>new ArticleCategoryViewModel
            {
                CategoryID = x.CategoryID,
                Title = x.Title,
                CreationDate = x.CreationDate.ToString(),
                IsDeleted = x.IsDeleted,

            }).ToList();
        }

        public ArticleCategoryViewModel GetBy(int categoryid)
        {
            var articleCategoryViewModel =
                mbContext.ArticleCategories.Select(x => new ArticleCategoryViewModel
                {
                    CategoryID = x.CategoryID,
                    Title = x.Title,
                    CreationDate = x.CreationDate.ToString(),
                    IsDeleted = x.IsDeleted,
                }).FirstOrDefault(x=>x.CategoryID==categoryid);

                return articleCategoryViewModel;
             
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Model.ArticleCategoryAgg.ArticleCategory articleCaregory)
        {
            throw new NotImplementedException();
        }
    }
}
