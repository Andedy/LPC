
using Microsoft.AspNetCore.Mvc;


namespace ToDoList.Web.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

     
    }
}
