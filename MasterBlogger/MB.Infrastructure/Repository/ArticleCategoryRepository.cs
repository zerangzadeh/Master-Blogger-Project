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
            SaveChanges();
        }

        public void Delete(long categoryID)
        {
            GetBy(categoryID).IsDeleted = true;
            SaveChanges();
        }
        public void Restore(long categoryID)
        {
            GetBy(categoryID).IsDeleted = false;
            SaveChanges();
        }

        public List<ArticleCategoryViewModel> GetAll()
        {
            return mbContext.ArticleCategories.OrderByDescending(x => x.CategoryID).Select(x => new ArticleCategoryViewModel
            {
                CategoryID = x.CategoryID,
                Title = x.Title,
                CreationDate = x.CreationDate.ToString(),
                IsDeleted = x.IsDeleted
            }).ToList();
        }

        public ArticleCategory GetBy(long categoryid)
        {
            return mbContext.ArticleCategories.FirstOrDefault(x => x.CategoryID == categoryid);

        }

        public void SaveChanges()
        {
            mbContext.SaveChanges();
        }

        public void Update(EditArticleCategoryCommand command)
        {
            GetBy(command.CategoryID).Title = command.Title;
            SaveChanges();
        }


    }
}
