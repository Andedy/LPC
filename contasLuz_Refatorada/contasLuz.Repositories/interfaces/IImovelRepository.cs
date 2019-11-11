using System.Collections.Generic;
using contasLuz.Entities;

namespace contasLuz.interfaces
{
    public interface IImovelRepositories
    {
        void Create(Imoveis Imoveis);
        void Update(Imoveis Imoveis);
        void Delete(int id);
        Imoveis GetById(int id);
        List<Imoveis> GetAll();
    }
}