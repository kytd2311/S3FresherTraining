using MVCDemo.Data.Identities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Services
{
    public interface IProductAdvertisementService
    {
        IList<ProductAdvertisement> GetSliderItems();
    }
}
