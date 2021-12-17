using MB.Application.Contracts.ArticleCategory;
using MB.Domain.Model.ArticleCategoryAgg;

namespace MB.Domain.Services
{
    public interface IArticleCategoryRepository
    {
        public void Create(ArticleCategory articleCaregory);
        public void Update(ArticleCategory articleCaregory);
        public void Delete(int categoryID);
        public ArticleCategoryViewModel GetBy(int categoryid);
        public List<ArticleCategoryViewModel> GetAll();
        public void SaveChanges();


    }
}