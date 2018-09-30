using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsSite.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual ICollection<News> news { get; set; }
    }
}