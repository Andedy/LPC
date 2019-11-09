using System.Collections.Generic;
using contasLuz.interfaces;
using contasLuz.Entities;

namespace contasLuz.MVC.ViewsModels
{
    public class ContaLuzViewModel
    {
        public ContaLuzViewModel(IContaLuzRepositories contaLuzRepositories)
        {
            this.listaContasLuz = contaLuzRepositories.Get();
            this.menorConsumo = contaLuzRepositories.GetMenorConsumo();
            this.maiorConsumo = contaLuzRepositories.GetMaiorConsumo();
        }

        public IEnumerable<ContaLuz> listaContasLuz { get; set; }
        public ContaLuz menorConsumo { get; set; }
        public ContaLuz maiorConsumo { get; set; }
    }
}