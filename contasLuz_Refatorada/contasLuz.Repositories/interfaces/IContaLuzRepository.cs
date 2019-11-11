using System.Collections.Generic;
using contasLuz.Entities;

namespace contasLuz.interfaces
{
    public interface IContaLuzRepositories : IRepositories<ContaLuz>
    {
        ContaLuz GetMenorConsumo();
        ContaLuz GetMaiorConsumo();
    }
}