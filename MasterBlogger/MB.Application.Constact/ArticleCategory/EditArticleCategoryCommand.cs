using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.ArticleCategory
{
    public class EditArticleCategoryCommand
    {
        public long CategoryID { get; set; }

        [DisplayName("عنوان دسته")]
        [Required(ErrorMessage = "عنوان دسته اجباری است")]
        public string Title { get; set; }
        
    }



}

