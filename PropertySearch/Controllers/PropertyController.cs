using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PropertySearch.Models;


namespace PropertySearch.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(RequirementsViewModel requirements)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", requirements);
            }
            requirements.Properties = new List<Property>()
            {
                new Property
                {
                    Price = 250000,
                    Bedrooms = 3,
                    Postcode = "WR5 3FB"
                },
                new Property
                {
                    Price = 275000,
                    Bedrooms = 4,
                    Postcode = "WR5 2AB"
                },
            };

            return View("Index", requirements);
        }
    }    
}