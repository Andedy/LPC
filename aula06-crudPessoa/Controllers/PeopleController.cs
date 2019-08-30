using aula06_crudPessoa.Models;
using Microsoft.AspNetCore.Mvc;

namespace aula06_crudPessoa.Controllers
{
    public class PeopleController : Controller
    {
        PersonRepository _repository = 
            new PersonRepository();
        public IActionResult Index()
        {
            var people = _repository.GetAll();
            return View(people);
        }
        
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Person person)
        {            
            _repository.Create(person);
            return RedirectToAction("Index");
        }
        
    }
}