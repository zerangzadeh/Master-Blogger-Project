using MB.Domain.Models.ArticleAgg.Exceptions;

namespace MB.Domain.Models.ArticleAgg.Services
{
    public class ArticleValidatorService : IArticleValidatorService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleValidatorService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public void CheckTheRecordAlreadyExist(string Title)
        {
            if (_articleRepository.Exist(Title))
                throw new DuplicatedRecordException("این مقاله قبلاْ ایجاد شده است.");
        }
    }
}
    

        
      