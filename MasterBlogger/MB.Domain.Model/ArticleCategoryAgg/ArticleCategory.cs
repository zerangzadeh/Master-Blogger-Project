namespace MB.Domain.Model.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long CategoryID { get; private set; } 
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }    
        public DateTime CreationDate { get;private set; }
       // public int ArticleID { get;private set; }
        //public Article Article { get; private set; }


        public ArticleCategory(string title)
        {
            Title = title.Trim();
            IsDeleted = false;
            CreationDate= DateTime.Now;


        }







    }
}
