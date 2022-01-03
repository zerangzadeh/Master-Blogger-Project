using MB.Domain.Models.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Models.CommentAgg
{
    public class Comment
    {
        public long CommentID { get; set; }
        public string CommentText { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }//0=New 1=Confirmed 2=Canceled
        public DateTime  CreationDate { get; set; }
        public long ArticleID { get; set; }

        public Article Article { get; set; }

        protected Comment()
        {
        }

        public Comment(string commentText, string userName, string email,long articleID)
        {
            CommentText = commentText;
            UserName = userName;
            Email = email;
            Status = Statuses.New;
            CreationDate = DateTime.Now;
            ArticleID = articleID;
           
        
        }
    }



}
