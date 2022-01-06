using MB.Application.Contracts;
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
        public void Update(EditArticleCommand article);
        public void Delete(long articleID);
        public void Restore(long articleID);
        public bool Exist(string Title);
        public EditArticleCommand GetDetails(long articleID);
        public List<ArticleViewModel> GetAll();
        public List<ArticleViewModel> GetLast(int number);
        public ArticleViewModel GetBy(long articleID);
        public void SaveChanges();

    }
}
