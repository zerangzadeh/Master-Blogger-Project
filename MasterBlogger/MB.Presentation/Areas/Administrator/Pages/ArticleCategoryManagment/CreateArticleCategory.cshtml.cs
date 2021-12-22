using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Areas.Administrator.Pages.ArticleCategoryManagment
{
    public class CreateArticleCategoryModel : PageModel
    {
        public CreateArticleCategoryCommand command { get; set; }
        readonly private IArticleCategoryApplication articleCategoryApplication;

        public CreateArticleCategoryModel(IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(CreateArticleCategoryCommand command)
        {
            articleCategoryApplication.Create(command);
            return RedirectToPage("./ArticleCategoryIndex");

        }
    }
}
