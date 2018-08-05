using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PropertySearch.Models;
using PropertySearch.Models.ViewModels;
using PropertySearch.Repositories;

namespace PropertySearch.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyRepository _propertyRepository;
        public PropertyController(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(PropertySearchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            
            var requirements = new Requirements {
                MaxBedrooms = model.MaxBedrooms,
                MinBedrooms = model.MinBedrooms,
                MaxPrice = model.MaxPrice,
                MinPrice = model.MinPrice,
                DistanceFromPostcode = model.DistanceFromPostcode,
                Postcode = model.Postcode
            };

            model.Properties = _propertyRepository.GetProperties(requirements);

            return View("Index", model);
        }
    }    
}