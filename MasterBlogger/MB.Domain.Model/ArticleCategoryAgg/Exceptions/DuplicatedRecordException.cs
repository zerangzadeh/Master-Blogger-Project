using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Models.ArticleCategoryAgg.Exceptions
{
    public class DuplicatedRecordException : Exception
    {
        public DuplicatedRecordException(string message) : base(message)
        {
        }
        
    }


    public class EmptyStringException : Exception
    {
        public EmptyStringException(string message) : base(message)
        {
        }
    }
   
}
