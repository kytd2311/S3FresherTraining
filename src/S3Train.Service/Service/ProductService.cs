using System;
using System.Collections.Generic;
using System.Linq;
using S3Train.Contract;
using S3Train.Domain;

namespace S3Train.Service
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Product> GetAll()
        {
            return _dbContext.Products.Where(x => x.IsActive).OrderBy(x => x.Price).ToList();
        }

        public Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}