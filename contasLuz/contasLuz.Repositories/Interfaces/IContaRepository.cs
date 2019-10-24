using System.Collections.Generic;
using contasLuz.Domain;

namespace contasLuz.Repositories.Interfaces
{
    public interface IContaRepository
    {   
        void Create(Conta conta);
        void Update(Conta conta);
        void Delete(int id);
        Conta GetById(int id);
        List<Conta> GetAll();
    }
}