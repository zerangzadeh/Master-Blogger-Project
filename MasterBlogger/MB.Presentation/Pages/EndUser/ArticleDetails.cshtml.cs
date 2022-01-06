using MB.Application.Contracts;
using MB.Application.Contracts.Article;
using MB.Application.Contracts.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MB.Presentation.Pages.EndUser
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViewModel Article { get; set; }
        //public List<CommentViewModel> Comments { get; set; }

        public AddComment comment { get; set; }

        private readonly IArticleApplication _articleApplication;
        private readonly ICommentApplication _commentApplication;
        public ArticleDetailsModel(IArticleApplication articleApplication,ICommentApplication commentApplication)
        {
            _articleApplication = articleApplication;
            _commentApplication = commentApplication;
        }

        public void OnGet(int ID)
        {
            Article = _articleApplication.GetBy(ID);
            //Comments = _commentApplication.GetAll();
           
        }

        public RedirectToPageResult OnPost(AddComment comment)
        {
            //comment.ArticleID = Article.ArticleID;
            _commentApplication.Create(comment);
            return RedirectToPage("./ArticleDetails", new { id = comment.ArticleID });
        }
    }
}


