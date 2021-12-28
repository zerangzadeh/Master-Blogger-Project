using MB.Application.Contracts.Article;
using MB.Domain.Models.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Services.ArticleApplication
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void Create(CreateArticleCommand article)
        {
            _articleRepository.Create(new Article(article.Title,article.ShortDESC,article.Body,article.PicTitle,article.PicALT,article.PicSrc,article.CategoryID));
               
        }

        public void Delete(long articleID)
        {
           _articleRepository.Delete(articleID);
        }

        public List<ArticleViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        //public List<ArticleViewModel> GetAll()
        //{
        //  _articleRepository.GetAll();
        //}

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
