using MB.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MB.Presentation.Pages.EndUser
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViewModel Article { get; set; }
        private readonly IArticleApplication _articleApplication;
        public ArticleDetailsModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet(int ID)
        {
            Article = _articleApplication.GetBy(ID);

        }
    }
}


