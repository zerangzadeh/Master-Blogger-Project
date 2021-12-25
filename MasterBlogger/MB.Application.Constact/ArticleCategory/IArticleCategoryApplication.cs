using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        public void Create(CreateArticleCategoryCommand articleCategoryCommand);
        public void Update(EditArticleCategoryCommand articleCategoryCommand);
        public void Delete(long categoryId);
        public void Restore(long categoryId);
        public List<ArticleCategoryViewModel> GetAll();
        public EditArticleCategoryCommand GetBy(long categoryId);




    }
}
