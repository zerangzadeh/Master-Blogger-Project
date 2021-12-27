using MB.Domain.Models.ArticleCategoryAgg.Exceptions;

namespace MB.Domain.Models.ArticleCategoryAgg.Services
{
    public class ArticleCategoryValidatorService : IArticleCategoryValidatorService
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidatorService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void CheckTheRecordAlreadyExist(string Title)
        {
            if (_articleCategoryRepository.Exist(Title))
                throw new DuplicatedRecordException("این دسته قبلاْ ایجاد شده است.");
             
        }
    }
}
