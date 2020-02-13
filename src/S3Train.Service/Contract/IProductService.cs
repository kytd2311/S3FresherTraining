using System;
using System.Collections.Generic;
using S3Train.Domain;

namespace S3Train.Contract
{
    public interface IProductService
    {
        IList<Product> GetAll();
        Product GetById(Guid id);
    }
}
