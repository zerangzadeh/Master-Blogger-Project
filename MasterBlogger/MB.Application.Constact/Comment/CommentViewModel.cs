using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.Comment
{
    public class CommentViewModel
    {
        public long CommentID { get; set; }
        public string CommentText { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }   
        public int Status { get; set; }
        public string CreationDate { get; set; }
        public string ArticleTitle { get; set; }
    }
}
