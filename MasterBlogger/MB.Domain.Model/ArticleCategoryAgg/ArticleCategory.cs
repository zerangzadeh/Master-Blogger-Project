using MB.Domain.Models.ArticleAgg;
using MB.Domain.Models.ArticleCategoryAgg.Exceptions;


namespace MB.Domain.Model.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long CategoryID { get; private set; } 
        public string Title { get;  set; }
        public bool IsDeleted { get;  set; }    
        public DateTime CreationDate { get;  set; }
        public List<Article> Articles { get; private set; }

        //This Constractor is just for Making Model by EFCORE

        protected ArticleCategory()
        {
        }
        
        public ArticleCategory(string title)
        {
                         
            Title = title.Trim();
            IsDeleted = false;
            CreationDate = DateTime.Now;
          
        }

       
    }
}
