using MVCDemo.Data.Identities;
using MVCDemo.Models;
using MVCDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductAdvertisementService _productAdvertisementService;

        public HomeController(IProductService productService, IProductAdvertisementService productAdvertisementService)
        {
            _productService = productService;
            _productAdvertisementService = productAdvertisementService;
        }

        public ActionResult Index()
        {
            var model = new HomeViewModel();
            model.SliderItems = GetHomeSlider(_productAdvertisementService.GetSliderItems());
            model.Products = GetHomeProducts(_productService.GetAll());

            return View(model);
        }

        private static IList<ProductViewModel> GetHomeProducts(IList<Product> products)
        {
            return products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                ImagePath = x.ImagePath,
                Name = x.Name,
                DisplayPrice = $"${x.Price}",
                Rating = x.Rating ?? 0,
                Summary = x.Summary
            }).ToList();
        }

        private static IList<SliderItemViewModel> GetHomeSlider(IList<ProductAdvertisement> productAds)
        {
            return productAds.Select(x => new SliderItemViewModel
            {
                ImagePath = x.ImagePath,
                Title = x.Title
            }).ToList();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}