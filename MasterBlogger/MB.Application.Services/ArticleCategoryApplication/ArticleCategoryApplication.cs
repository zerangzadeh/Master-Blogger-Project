using MB.Application.Contracts.ArticleCategory;
using MB.Domain.Model.ArticleCategoryAgg;
using MB.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Services.ArticleCategoryApplication
{
    public  class ArticleCategoryApplication : IArticleCategoryApplication
    {
        readonly private IArticleCategoryRepository articleCategoryRepositpry;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepositpry)
        {
            this.articleCategoryRepositpry = articleCategoryRepositpry;
        }

        public void Create(CreateArticleCategoryCommand articleCategoryCommand)
        {
            var articleCategory = new ArticleCategory(articleCategoryCommand.Title);
            this.articleCategoryRepositpry.Create(articleCategory);
        }

      
        public void Delete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<ArticleCategoryViewModel> GetAll()
        {
           return articleCategoryRepositpry.GetAll();
            
        }

        public List<ArticleCategoryViewModel> GetBy(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Restore(int categoryId)
        {
            throw new NotImplementedException();
        }

    /*
        public void Update(ArticleCategoryForUpdate articleCategory)
        {
            throw new NotImplementedException();
        }
    */
    }
}
