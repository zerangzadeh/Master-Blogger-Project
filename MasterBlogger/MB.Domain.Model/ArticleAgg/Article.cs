using MB.Domain.Model.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Models.ArticleAgg
{
    public class Article
    {
        public int ArticleID { get; private set; }
        public string Title { get; private set; }
        public string ShortDESC { get; private set; }
        public string Body { get; private set; }
        public string PicTitle { get; private set; }
        public string PicALT { get; private set; }
        public string PicSrc { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public long CategoryID { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }

        //This Constractor is just for Making Model by EFCORE
        protected Article()
        {
        }

        public Article(string title, string shortDESC, string body, string picTitle, string picALT, string picSrc,long categoryID)
        {

            Title = title;
            ShortDESC = shortDESC;
            Body = body;
            PicTitle = picTitle;
            PicALT = picALT;
            PicSrc = picSrc;
            CategoryID = categoryID;
            IsDeleted = false;
            CreationDate = DateTime.Now;
           
        }
    }
}
