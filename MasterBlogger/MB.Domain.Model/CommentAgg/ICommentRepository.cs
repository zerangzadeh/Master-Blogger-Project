﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Models.CommentAgg
{
    public interface ICommentRepository
    {
        public void Create(Comment comment);
        public void Restore(long commentID);
        public void Delete(long commentID);
        public List<Comment>  GetAll();
        public int GetCount(long articleID);
        public List<Comment> GetBy(long CommentID);
        public void SaveChanges();

    }
}
