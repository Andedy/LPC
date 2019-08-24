using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aula05MVC.Models;
using System.Collections.Generic;

namespace aula05MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Conta> contas = new List<Conta>();
            
            contas.Add(new Conta {codigo=1, titular="Maria"});
            contas.Add(new Conta {codigo=2, titular="Joao"});
            contas.Add(new Conta {codigo=3, titular="Alice"});

            return View(contas);
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
