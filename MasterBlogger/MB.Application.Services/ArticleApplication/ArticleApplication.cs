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
            _articleRepository.Create(new Article(article.Title, article.ShortDESC, article.Body, article.PicTitle, article.PicALT, article.PicSrc, article.CategoryID));

        }

        public void Delete(long articleID)
        {
            _articleRepository.Delete(articleID);
        }

        public void Restore(long articleID)
        {
            _articleRepository.Restore(articleID);
        }

        public List<ArticleViewModel> GetAll()
        {
            return _articleRepository.GetAll();
        }

        public List<ArticleViewModel> GetLast(int Number)
        {
            return _articleRepository.GetLast(Number);
        }


        public void Update(EditArticleCommand articleCommand)
        {
            _articleRepository.Update(articleCommand);
        }

        public ArticleViewModel GetBy(long articleID)
        {
            return _articleRepository.GetBy(articleID);

        }

        public EditArticleCommand GetDetails(long articleID)
        {
            return _articleRepository.GetDetails(articleID);
        }
    }
    }

