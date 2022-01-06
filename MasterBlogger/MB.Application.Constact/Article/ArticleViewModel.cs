using MB.Application.Contracts.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts
{
    public class ArticleViewModel
    {
        public long ArticleID { get; set; }
        public string Title { get; set; }
        public string ShortDESC { get; set; }
        public string Body { get; set; }
        public string PicTitle { get; set; }
        public string PicALT { get; set; }
        public string PicSrc { get; set; }
        public bool IsDeleted { get; set; }
        public string CreationDate { get; set; }
        public string CategoryTitle { get; set; }

        public int CommentCount { get; set; }
        public List<CommentViewModel> Comments;
        //= new List<CommentViewModel>();

        
    }
}
