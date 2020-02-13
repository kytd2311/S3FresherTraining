using MVCDemo.Data;
using MVCDemo.Data.Identities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Services
{
    public class ProductAdvertisementService : IProductAdvertisementService
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductAdvertisementService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<ProductAdvertisement> GetSliderItems()
        {
            return _dbContext.ProductAdvertisements.Where(x => x.AdType == ProductAdvertisementType.SliderBanner && x.IsActive).ToList();
        }
    }
}