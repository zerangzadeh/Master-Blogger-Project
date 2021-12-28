using MB.Domain.Models.ArticleAgg;
using MB.Domain.Models.ArticleCategoryAgg.Exceptions;
using MB.Domain.Models.ArticleCategoryAgg.Services;

namespace MB.Domain.Model.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long CategoryID { get; private set; } 
        public string Title { get;  set; }
        public bool IsDeleted { get;  set; }    
        public DateTime CreationDate { get;  set; }
        
        // public int ArticleID { get;private set; }
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
        public ArticleCategory(string title,IArticleCategoryValidatorService validatorService)
        {
            GaurdAgainstEmpty(title);
            validatorService.CheckTheRecordAlreadyExist(title);
           
            Title = title.Trim();
            IsDeleted = false;
            CreationDate = DateTime.Now;
          
        }

        public void GaurdAgainstEmpty(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new EmptyStringException("خطای رشته خالی");
        }
    }
}
