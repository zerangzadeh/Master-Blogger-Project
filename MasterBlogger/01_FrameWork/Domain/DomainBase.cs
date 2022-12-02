namespace _01_FrameWork
{
    public class DomainBase<T> 
  
    {
        public T ID { get; set; }
        public DateTime CreationDate { get; set; }

        public DomainBase()
        {
        }

        public DomainBase(DateTime creationDate)
        {
            CreationDate = DateTime.Now;
        }
    }

}