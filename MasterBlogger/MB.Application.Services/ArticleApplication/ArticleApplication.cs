using MB.Application.Contracts.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Services.ArticleApplication
{
    public class ArticleApplication : IArticleApplication
    {
        public void Create(CreateArticleCommand articleCommand)
        {
            throw new NotImplementedException();
        }

        public void Delete(long articleID)
        {
            throw new NotImplementedException();
        }

        public List<ArticleViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ArticleViewModel GetBy(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(EditArticleCommandcs articleCommand)
        {
            throw new NotImplementedException();
        }
    }
}
