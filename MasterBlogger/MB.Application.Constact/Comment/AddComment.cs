using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.Comment
{
    public class AddComment
    {
        public string CommentText { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public long ArticleID { get; set; }

    }
}
