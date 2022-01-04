using MB.Application.Contracts.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Areas.Administrator.Pages.CommentManagement
{
    public class CommentIndexModel : PageModel
    {
        private readonly ICommentApplication _commentApplication;
        public List<CommentViewModel> comments;

        public CommentIndexModel(ICommentApplication commentApplication)
        {
           _commentApplication = commentApplication;
        }

        public void OnGet()
        {
           comments=_commentApplication.GetAll();
        }

    }
}
