using MB.Application.Contracts.Article;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Areas.Administrator.Pages.ArticleManagment
{
    public class ArticleIndexModel : PageModel
    {
        public List<ArticleViewModel> articles { get; set; }
        private readonly IArticleApplication _articleApplication;


        public ArticleIndexModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            articles = _articleApplication.GetAll();
        }

        //public RedirectToPageResult OnGetRestore(int id)
        //{
        //    articleCategoryApplication.Restore(id);
        //    return RedirectToPage("./ArticleCategoryIndex");
        //}
        //public RedirectToPageResult OnGetDelete(int id)
        //{
        //    articleCategoryApplication.Delete(id);
        //    return RedirectToPage("./ArticleCategoryIndex");
        //}
    }
}
