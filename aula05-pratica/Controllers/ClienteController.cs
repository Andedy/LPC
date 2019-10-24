using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aula05_pratica.Models;
using Microsoft.AspNetCore.Http;

namespace aula05_pratica.Controllers
{
    public class ClienteController : Controller
    {
        private static Cliente cliente = new Cliente(); 

        public IActionResult Index()
        {
            return View(cliente.listaClientes);
        }

        public IActionResult CreateCliente()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult CreateCliente(ClienteModel clienteModel)
        {
            cliente.CreateCliente(clienteModel);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCliente(int id)
        {
            return View(cliente.GetCliente(id));
        }

        [HttpPost]
        public RedirectToActionResult UpdateCliente(ClienteModel clienteModel)
        {
            cliente.UpdateCliente(clienteModel);
            return RedirectToAction("Index");
        }

        public IActionResult ViewCliente(int id)
        {
            return View(cliente.GetCliente(id));
        }

        public RedirectToActionResult DeleteCliente(int id)
        {
            cliente.DeleteCliente(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}