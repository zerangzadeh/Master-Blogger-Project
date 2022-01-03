using MB.Domain.Model.ArticleCategoryAgg;
using MB.Domain.Models.ArticleAgg.Exceptions;
using MB.Domain.Models.ArticleAgg.Services;
using MB.Domain.Models.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Models.ArticleAgg
{
    public class Article
    {
        public long ArticleID { get;  set; }
        public string Title { get;  set; }
        public string ShortDESC { get;  set; }
        public string Body { get;  set; }
        public string PicTitle { get;  set; }
        public string PicALT { get;  set; }
        public string PicSrc { get;  set; }
        public bool IsDeleted { get;  set; }
        public DateTime CreationDate { get;  set; }
        public long CategoryID { get;  set; }
        public ArticleCategory ArticleCategory { get;  set; }
        public List<Comment> Comments { get; set; }

        //This Constractor is just for Making Model by EFCORE
        protected Article()
        {
        }

        public Article(string title, string shortDESC, string body, string picTitle, string picALT, string picSrc,long categoryID)
        {
            //Validation(title,categoryID);
           // validatorServices.CheckTheRecordAlreadyExist(title);
            Title = title;
            ShortDESC = shortDESC;
            Body = body;
            PicTitle = picTitle;
            PicALT = picALT;
            PicSrc = picSrc;
            IsDeleted = false;
            CreationDate = DateTime.Now;
            CategoryID = categoryID;
        }

       
    }
}
