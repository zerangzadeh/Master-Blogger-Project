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
        public void Update(EditArticleCommand articleCommand);
        public void Delete(long articleID);
        public void Restore(long articleID);
        //public ArticleViewModel GetDetails(long articleID);
        public List<ArticleViewModel> GetAll();
        public List<ArticleViewModel> GetLast(int Number);
        public ArticleViewModel GetBy(long id);
        public EditArticleCommand GetDetails(long id);
    }
}
