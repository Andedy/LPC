using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using contasLuz.Entities;
using contasLuz.interfaces;
using contasLuz.MVC.Models;
using contasLuz.MVC.ViewsModels;

namespace contasLuz.MVC.Controllers
{
    public class ContaLuzController : Controller
    {
        private readonly IContaLuzRepositories contaLuzRepositories;
        private readonly IImovelRepositories imovelRepositories;

        public ContaLuzController(IContaLuzRepositories contaLuzRepositories, IImovelRepositories imovel)
        {
            this.contaLuzRepositories = contaLuzRepositories;
            this.imovelRepositories = imovel;
        }

        public IActionResult Index()
        {
            ViewBag.imovel= imovelRepositories.GetAll();
            return View(new ContaLuzViewModel(contaLuzRepositories));
        }

        public IActionResult View(int id)
        {
            return View(contaLuzRepositories.Get(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
         //   ViewBag.Topico = new SelectList(db.Topicoes, "Id", "Nome");

            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(ContaLuz contaLuz)
        {
            contaLuzRepositories.Insert(contaLuz);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(contaLuzRepositories.Get(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(ContaLuz contaLuz)
        {
            contaLuzRepositories.Update(contaLuz);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            contaLuzRepositories.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}