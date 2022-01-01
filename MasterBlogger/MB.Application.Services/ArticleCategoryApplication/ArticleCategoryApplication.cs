using MB.Application.Contracts.ArticleCategory;
using MB.Domain.Model;
using MB.Domain.Model.ArticleCategoryAgg;
using MB.Domain.Models.ArticleCategoryAgg;
using MB.Domain.Models.ArticleCategoryAgg.Services;

namespace MB.Application.Services.ArticleCategoryApplication
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        readonly private IArticleCategoryRepository _articleCategoryRepositpry;
       
        

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepositpry)
        {
            _articleCategoryRepositpry = articleCategoryRepositpry;
          
        }

        public void Create(CreateArticleCategoryCommand articleCategoryCommand)
        {
            var articleCategory = new ArticleCategory(articleCategoryCommand.Title);
            _articleCategoryRepositpry.Create(articleCategory);
        }


        public void Delete(long categoryId)
        {
            _articleCategoryRepositpry.Delete(categoryId);
        }

        public List<ArticleCategoryViewModel> GetAll()
        {
            return _articleCategoryRepositpry.GetAll();

        }

        public EditArticleCategoryCommand GetBy(long categoryId)
        {
            var articleCategory=_articleCategoryRepositpry.GetBy(categoryId);
            return new EditArticleCategoryCommand
            {
                CategoryID = articleCategory.CategoryID,
                Title = articleCategory.Title
            };

        }




    public void Restore(long categoryId)
    {
            _articleCategoryRepositpry.Restore(categoryId);
    }



    public void Update(EditArticleCategoryCommand articleCategoryCommand)
    {
        _articleCategoryRepositpry.Update(articleCategoryCommand);
    }


}
}
