using System.Collections.Generic;
using System.IO;
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
        /// <summary>
        /// Searches for all properties that match given requirements
        /// </summary>
        /// <param name="model">Propert Search view model with requirements</param>
        /// <returns>Property View model with search results</returns>
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

        /// <summary>
        /// Returns Image data from repository
        /// </summary>
        /// <param name="id">Image Id</param>
        /// <returns>Base 64 encoded Image source</returns>
        [HttpGet]
        public IActionResult Image(string id)
        {
            try
            {
                return Content(_propertyRepository.Image(id));
            }
            catch (FileNotFoundException)
            {
                return NotFound();
            }
        }
    }    
}