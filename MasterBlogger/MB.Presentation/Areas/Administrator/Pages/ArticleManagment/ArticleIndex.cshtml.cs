//using MB.Application.Contracts.ArticleCategory;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;

//namespace MB.Presentation.Areas.Administrator.Pages.ArticleCategoryManagment
//{
//    public class ArticleIndexModel : PageModel
//    {
//        public List<ArticleCategoryViewModel> articleCategories { get; set; }
//        private readonly IArticleCategoryApplication articleCategoryApplication;


//        public ArticleIndexModel(IArticleCategoryApplication articleCategoryApplication)
//        {
//            this.articleApplication = articleCategoryApplication;
//        }

//        public void OnGet()
//        {
//            articleCategories = articleCategoryApplication.GetAll();
//        }

//        public RedirectToPageResult OnGetRestore(int id)
//        {
//            articleCategoryApplication.Restore(id);
//            return RedirectToPage("./ArticleCategoryIndex");
//        }
//        public RedirectToPageResult OnGetDelete(int id)
//        {
//            articleCategoryApplication.Delete(id);
//            return RedirectToPage("./ArticleCategoryIndex");
//        }
//    }
//}
