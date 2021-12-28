using MB.Application.Contracts.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Models.ArticleAgg
{
    public interface IArticleRepository
    {
        public void Create(Article article);
        public void Update(Article article);
        public void Delete(long articleID);
        //public List<ArticleViewModel> GetAll();
        public Article GetBy(long articleID);
        public void SaveChanges();

    }
}
