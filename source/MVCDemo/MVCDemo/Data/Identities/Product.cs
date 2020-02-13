using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Data.Identities
{
    public class Product : BaseIdentity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public int? Rating { get; set; }

        public virtual Category Category { get; set; }
    }
}