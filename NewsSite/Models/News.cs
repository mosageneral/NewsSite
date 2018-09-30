using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsSite.Models
{
    public class News
    {
        public int Id { get; set; }


        [Display(Name = "عنوان الخبر ")]
        [Required]
        public string Name { get; set; }



        [Display(Name = "محتوى الخبر  ")]
        [Required]
        public string Description { get; set; }


        [Display(Name = "صورة الخبر ")]
       
        public string Image { get; set; }



        [Display(Name = "تاريخ نشر الخبر ")]
        [Required]
        public int PublishDate { get; set; }



        [Display(Name = "ناشر الخبر ")]
        [Required]
        public string Publisher { get; set; }


        public int categoryId { get; set; }


      
        public virtual Category category { get; set; }


       
    }
}