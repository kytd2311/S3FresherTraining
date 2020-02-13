using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Data.Identities
{
    public class ProductAdvertisement : BaseIdentity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string EventUrl { get; set; }
        public string EventUrlCaption { get; set; }
        public string ImagePath { get; set; }
        public ProductAdvertisementType AdType { get; set; }
    }
}