using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aula08crudPeople.Models;

namespace aula08crudPeople.Controllers
{
    public class PeopleController : Controller
    {
        private IPersonRepository repository;
        public PeopleController(IPersonRepository repository){
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Create()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
