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
    public class ArticleCategoryApplication : IArticleCategoryApplication
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


        public void Delete(long categoryId)
        {
            articleCategoryRepositpry.Delete(categoryId);
        }

        public List<ArticleCategoryViewModel> GetAll()
        {
            return articleCategoryRepositpry.GetAll();

        }

        public EditArticleCategoryCommand GetBy(long categoryId)
        {
            var articleCategory=articleCategoryRepositpry.GetBy(categoryId);
            return new EditArticleCategoryCommand
            {
                CategoryID = articleCategory.CategoryID,
                Title = articleCategory.Title
            };

        }




    public void Restore(long categoryId)
    {
            articleCategoryRepositpry.Restore(categoryId);
    }



    public void Update(EditArticleCategoryCommand articleCategoryCommand)
    {
        articleCategoryRepositpry.Update(articleCategoryCommand);
    }


}
}
