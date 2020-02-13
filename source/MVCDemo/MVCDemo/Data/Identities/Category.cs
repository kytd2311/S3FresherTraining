using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Data.Identities
{
    public class Category : BaseIdentity
    {
        public string Name { get; set; }
        public string Summary { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}