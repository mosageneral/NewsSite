using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsSite.Models
{
    public class Livebrodcast
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "رابط البث المباشر ")]
        public string BrodcastLink { get; set; }
    }
}