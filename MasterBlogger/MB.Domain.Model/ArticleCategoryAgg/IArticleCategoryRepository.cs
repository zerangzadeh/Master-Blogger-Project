using MB.Application.Contracts.ArticleCategory;
using MB.Domain.Model.ArticleCategoryAgg;
using MB.Domain.Models.ArticleCategoryAgg;

namespace MB.Domain.Models.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        public void Create(ArticleCategory articleCaregory);
        public void Update(EditArticleCategoryCommand command);
        public void Delete(long categoryID);
        public void Restore(long categoryID);
        public bool Exist(string Title);
        public ArticleCategory GetBy(long categoryid);
        public List<ArticleCategoryViewModel> GetAll();
        public void SaveChanges();


    }
}