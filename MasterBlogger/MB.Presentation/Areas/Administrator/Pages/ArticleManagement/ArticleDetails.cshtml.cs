using MB.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MB.Presentation.Areas.Administrator.Pages.ArticleManagment
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViewModel article { get; set; }
        private readonly IArticleApplication _articleApplication;
        public ArticleDetailsModel(IArticleApplication articleApplication)
        {
           _articleApplication = articleApplication;
        }

        public void OnGet(int ID)
        {
            article = _articleApplication.GetBy(ID);
            
        }
    }
}

