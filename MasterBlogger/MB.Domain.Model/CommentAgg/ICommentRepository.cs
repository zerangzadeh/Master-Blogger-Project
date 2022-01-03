using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Models.CommentAgg
{
    public interface ICommentRepository
    {
        public void Create(Comment comment);
        public void Update(Comment comment);
        public void Delete(long commentID);
        public List<Comment>  GetAll();
        public int GetCount();
        public Comment GetBy(long CommentID);

    }
}
