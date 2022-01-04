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

        public void Delete(long commentID)
        {
           _commentRepository.Delete(commentID);
        }

        public List<CommentViewModel> GetAll()
        {
                     
           return  _commentRepository.GetAll().Select(x=>new CommentViewModel
             {
                 CommentID = x.CommentID,
                 CommentText=x.CommentText,
                 UserName=x.UserName,
                 Email=x.Email,
                 Status=x.Status,
                 CreationDate=x.CreationDate.ToString(),
                 ArticleTitle=x.Article.Title

             }).ToList();
        }
        //public List<CommentViewModel> GetAllAdmin(long articleID)
        //{

        //    return _commentRepository.GetAll(articleID).Select(x => new CommentViewModel
        //    {
        //        CommentID = x.CommentID,
        //        CommentText = x.CommentText,
        //        UserName = x.UserName,
        //        Email=x.Email,
        //        CreationDate = x.CreationDate.ToString(),
        //        ArticleTitle = x.Article.Title,
        //    }).ToList();
        //}

        public int GetCount(long articleID)
        {
           return _commentRepository.GetCount(articleID);
        }

        public void Restore(long commentID)
        {
            _commentRepository.Restore(commentID);
        }

    }
}
