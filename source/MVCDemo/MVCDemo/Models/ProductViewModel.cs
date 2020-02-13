using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string DisplayPrice { get; set; }
        public int Rating { get; set; }
    }
}