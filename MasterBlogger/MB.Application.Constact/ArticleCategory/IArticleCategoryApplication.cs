using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        //public void Create(ArticleCategoryForCreate articleCategory);
        //public void Update(ArticleCategoryForUpdate articleCategory);
        public void Delete(int categoryId);
        public void Restore(int categoryId);
        public List<ArticleCategoryViewModel> GetAll();
        public List<ArticleCategoryViewModel> GetBy(int categoryId);




    }
}
