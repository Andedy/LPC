using System.Collections.Generic;
using contasLuz.Entities;

namespace contasLuz.interfaces
{
    public interface IContaLuzRepository : IRepository<ContaLuz>
    {
        ContaLuz GetMenorConsumo();
        ContaLuz GetMaiorConsumo();
    }
}