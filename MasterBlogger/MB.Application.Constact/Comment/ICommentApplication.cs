using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.Comment
{
    public interface ICommentApplication
    {
        public void Create(AddComment comment);
        List<CommentViewModel> GetAll();
       // List<CommentViewModel> GetAllAdmin(long iD);
        //public void Update(Comment comment);
        //public void Delete(long commentID);
        //public List<Comment> GetAll();
        public int GetCount(long articleID);
        //public Comment GetBy(long CommentID);
    }
}
