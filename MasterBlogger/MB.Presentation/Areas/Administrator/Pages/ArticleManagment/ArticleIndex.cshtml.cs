using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Areas.Administrator.Pages.ArticleCategoryManagment
{
    public class ArticleCategoryIndexModel : PageModel
    {
        public List<ArticleCategoryViewModel> articleCategories { get; set; }
        private readonly IArticleCategoryApplication articleCategoryApplication;


        public ArticleCategoryIndexModel(IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            articleCategories = articleCategoryApplication.GetAll();
        }

        public RedirectToPageResult OnGetRestore(int id)
        {
            articleCategoryApplication.Restore(id);
            return RedirectToPage("./ArticleCategoryIndex");
        }
        public RedirectToPageResult OnGetDelete(int id)
        {
            articleCategoryApplication.Delete(id);
            return RedirectToPage("./ArticleCategoryIndex");
        }
    }
}
