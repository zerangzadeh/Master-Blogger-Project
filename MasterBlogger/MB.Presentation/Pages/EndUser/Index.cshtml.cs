using MB.Application.Contracts.Article;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleViewModel> articles { get; set; }
        private readonly IArticleApplication _articleApplication;


        public IndexModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            articles = _articleApplication.GetAll();
        }

       
    }
}
