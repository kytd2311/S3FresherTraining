using System.Collections.Generic;
using System.Linq;
using S3Train.Contract;
using S3Train.Domain;

namespace S3Train.Service
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