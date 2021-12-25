using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Areas.Administrator.Pages.ArticleCategoryManagment
{
    public class EditArticleCategoryModel : PageModel
    {
        [BindProperty] public EditArticleCategoryCommand command { get; set; }
       // public ArticleCategoryViewModel articleCategoryViewModel; 
        readonly private IArticleCategoryApplication articleCategoryApplication;
       

        public EditArticleCategoryModel(IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(int ID)
        {
            command = articleCategoryApplication.GetBy(ID);
          
        }
        public RedirectToPageResult OnPost()
        {
            articleCategoryApplication.Update(command);
            return RedirectToPage("./ArticleCategoryIndex");

        }
       
    }


    

   
}
