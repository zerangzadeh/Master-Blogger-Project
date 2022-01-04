using MB.Domain.Models.CommentAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MBContext mBContext;

        public CommentRepository(MBContext mBContext)
        {
            this.mBContext = mBContext;
        }

        public void Create(Comment comment)
        {
            mBContext.Comments.Add(comment);
            SaveChanges();
        }

        public void Delete(long commentID)
        {
          var comment=mBContext.Comments.FirstOrDefault(x=>x.CommentID==commentID);
            if (comment!=null)
            {
                comment.Status = Status.Canceled;
            }
            SaveChanges();

        }

        public List<Comment> GetAll()
        {
           return mBContext.Comments.Include(x=>x.Article).OrderByDescending(x => x.CommentID).ToList();
        }

        public Comment GetBy(long commentID)
        {
            return mBContext.Comments.FirstOrDefault(predicate: x =>x.CommentID==commentID);
        }

        public int GetCount(long articleID)
        {
            return mBContext.Comments.Where(x=>x.ArticleID==articleID).Count();
        }

        public void SaveChanges()
        {
          mBContext.SaveChanges();
        }

        public void Update(Comment comment)
        {
            throw new NotImplementedException();
        }

        //public void Update(Comment comment)
        //{
        //    var commentTmp = GetBy(comment.CommentID);
        //    if (commentTmp!=null)
        //    {
        //        commentTmp.CommentText = comment.CommentText;
        //        commentTmp.Status = comment.Status;
        //        commentTmp.UserName = comment.UserName;
        //        commentTmp.Email = comment.Email;
        //        commentTmp.CreationDate = comment.CreationDate;
        //        commentTmp.
        //    }

        //}
    }
}
