using MB.Application.Contracts.Article;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.Areas.Administrator.Pages.ArticleManagement
{
    public class EditArticleModel : PageModel
    {
        public EditArticleCommand command { get; set; }
       
        [TempData]
        public string ErrorMessage { get; set; }
        public SelectList articleCategory;
        //[BindProperty]
        // public IFormFile PicSrc { get; set; }
        private IWebHostEnvironment _env;
        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditArticleModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication, IWebHostEnvironment env)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
            _env = env;
        }

        public void OnGet(long ID)
        {
            articleCategory = new SelectList(_articleCategoryApplication.GetAll(), "CategoryID", "Title");
            command = _articleApplication.GetDetails(ID);
        }

        public IActionResult OnPost(EditArticleCommand command)
        {

            //var UploadFile = PicSrc.FileName;
            //var filePath = Path.Combine(_env.WebRootPath, "Images", UploadFile);

            //using (var stream = System.IO.File.Create(filePath))
            //{
            //    PicSrc.CopyTo(stream);
            //}

            // End Of Upload File
            //command.PicSrc = filePath;
            if (ModelState.IsValid)
            {    //Upload File

                _articleApplication.Update(command);
                return RedirectToPage("./ArticleIndex");
            }
            else
            {
                ErrorMessage = "لطفا مقادیر خواسته شده را تکمیل نمایید.";
                return Page();
            }

        }
    }
}
