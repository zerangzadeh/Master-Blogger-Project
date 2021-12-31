using AutoMapper;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.Model.ArticleCategoryAgg;
using MB.Domain.Models.ArticleCategoryAgg;

namespace MB.Infrastructure.Repository
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MBContext mbContext;
        private readonly IMapper _mapper;

        public ArticleCategoryRepository(MBContext mbContext,IMapper mapper)
        {
            this.mbContext = mbContext;
             _mapper = mapper;
        }

        public void Create(ArticleCategory articleCaregory)
        {
            mbContext.ArticleCategories.Add(articleCaregory);
            SaveChanges();
        }

        public void Delete(long categoryID)
        {
            GetBy(categoryID).IsDeleted = true;
            SaveChanges();
        }
        public void Restore(long categoryID)
        {
            GetBy(categoryID).IsDeleted = false;
            SaveChanges();
        }

        public List<ArticleCategoryViewModel> GetAll()
        {
         
            return mbContext.ArticleCategories.OrderByDescending(x => x.CategoryID).Select(x => new ArticleCategoryViewModel
            {
                CategoryID = x.CategoryID,
                Title = x.Title,
                CreationDate = x.CreationDate.ToString(),
                IsDeleted = x.IsDeleted
            }).ToList();
        }

        public ArticleCategory GetBy(long categoryid)
        {
            return mbContext.ArticleCategories.FirstOrDefault(x => x.CategoryID == categoryid);

        }

        public void SaveChanges()
        {
            mbContext.SaveChanges();
        }

        public void Update(EditArticleCategoryCommand command)
        {
            //var aticleCategory = GetBy(command.CategoryID).Title;
            //var mapModel = _mapper.Map<AticleCategory>(command);
            //SaveChanges();
            GetBy(command.CategoryID).Title = command.Title;
            SaveChanges();
        }

        public bool Exist(string Title)
        {
          return mbContext.ArticleCategories.Any(x => x.Title == Title);  
        }
    }
}
