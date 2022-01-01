namespace MB.Domain.Models.ArticleAgg.Exceptions
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException(string message) : base(message)
        {
        }
    }

}
