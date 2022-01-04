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
        public void Restore(long commentID);
        public void Delete(long commentID);
        //public List<Comment> GetAll();
        public int GetCount(long articleID);
        //public Comment GetBy(long CommentID);
    }
}
