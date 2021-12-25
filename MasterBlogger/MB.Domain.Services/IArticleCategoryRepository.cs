using MB.Application.Contracts.ArticleCategory;
using MB.Domain.Model.ArticleCategoryAgg;

namespace MB.Domain.Services
{
    public interface IArticleCategoryRepository
    {
        public void Create(ArticleCategory articleCaregory);
        public void Update(EditArticleCategoryCommand command);
        public void Delete(long categoryID);
        public void Restore(long categoryID);
        public ArticleCategory GetBy(long categoryid);
        public List<ArticleCategoryViewModel> GetAll();
        public void SaveChanges();


    }
}