using MVCDemo.Data;
using MVCDemo.Data.Identities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Services
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