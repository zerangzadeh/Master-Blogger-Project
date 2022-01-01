using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Models.ArticleAgg.Services
{
    public interface IArticleValidatorService
    {
        void CheckTheRecordAlreadyExist(string Title);
    }
}
