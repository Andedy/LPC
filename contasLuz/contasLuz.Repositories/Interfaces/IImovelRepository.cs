using System.Collections.Generic;
using contasLuz.Domain;

namespace contasLuz.Repositories.Interfaces
{
    public interface IImovelRepository
    {
        void Insert(Imovel obj);
        void Update(Imovel obj);
        void Delete(int id);
        Imovel GetById(int id);
        List<Imovel> GetAll();
    }
}


