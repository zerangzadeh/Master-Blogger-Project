﻿using MB.Application.Contracts.Article;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.Areas.Administrator.Pages.ArticleManagement
{
    public class CreateArticleModel : PageModel
    {
        public CreateArticleCommand command { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }
        public SelectList articleCategory;
        [BindProperty]
        public IFormFile PicSrc { get; set; }
        private IWebHostEnvironment _env;
        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateArticleModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication, IWebHostEnvironment env)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
            _env = env;
        }

        public void OnGet()
        {
            articleCategory=new SelectList(_articleCategoryApplication.GetAll(),"CategoryID","Title");
        }

        public IActionResult OnPost(CreateArticleCommand command)
        {

            var UploadFile = PicSrc.FileName;
            var filePath = Path.Combine(_env.WebRootPath, "Images", UploadFile);

            using (var stream = System.IO.File.Create(filePath))
            {
                PicSrc.CopyTo(stream);
            }

            //End Of Upload File
            command.PicSrc = UploadFile;
            if (ModelState.IsValid)
            {    //Upload File
               
                _articleApplication.Create(command);
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
