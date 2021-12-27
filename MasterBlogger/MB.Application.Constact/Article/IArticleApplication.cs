using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        public void Create(CreateArticleCommand articleCommand);
        public void Update(EditArticleCommandcs articleCommand);
        public void Delete(long articleID);
        public List<ArticleViewModel> GetAll();
        public ArticleViewModel GetBy(long id);
    }
}
