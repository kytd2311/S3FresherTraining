﻿using System.Collections.Generic;
using S3Train.Domain;

namespace S3Train.Contract
{
    public interface IProductAdvertisementService
    {
        IList<ProductAdvertisement> GetSliderItems();
    }
}
