using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Areas.Administrator.Pages.ArticleCategoryManagment
{
    public class CreateArticleCategoryModel : PageModel
    {
        public CreateArticleCategoryCommand command { get; set; }
        readonly private IArticleCategoryApplication articleCategoryApplication;
        [TempData]
        public string ErrorMessage { get; set; }
       
       

        public CreateArticleCategoryModel(IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(CreateArticleCategoryCommand command)
        {
            if (ModelState.IsValid)
            {
                articleCategoryApplication.Create(command);
                return RedirectToPage("./ArticleCategoryIndex");
            }
            else
            {
                ErrorMessage = "لطفا مقادیر خواسته شده را تکمیل نمایید.";
                return RedirectToPage("./CreateArticleCategory");
            }

        }
    }
}
