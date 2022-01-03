using MB.Application.Contracts.Comment;
using MB.Domain.Models.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Services.CommentApplication
{
    public class CommentApplication:ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void Create(AddComment command)
        {  var comment=new Comment(command.CommentText, command.UserName, command.Email, command.ArticleID);
            _commentRepository.Create(comment);

        }
    }
}
