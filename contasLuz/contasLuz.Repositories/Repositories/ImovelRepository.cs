using System.Collections.Generic;
using System.Linq;
using Data;
using Domain.Entities;
using Repositories.Interfaces;

namespace contasLuz.Repositories.Repositories
{

    public class ImovelRepository{

        public class ImovelRepository : IImovelRepository
    {
        private DbContext _context;
    
        public ImovelRepository(DbContext context)
        {           
            this._context = context;
        }
        public void Insert(Imovel obj)
        {
            _context.imovel.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Imovel obj)
        {
            var imovelMod = GetById(obj.id);
            imovelMod.bairro = obj.bairro;
            imovelMod.cidade = obj.cidade;
            imovelMod.estado = obj.estado;
            imovelMod.identificacao = obj.identificacao;
            imovelMod.numero = obj.numero;
            
            
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.imovel.Remove(GetById(id));
            _context.SaveChanges();
        }

        public Imovel GetById(int id)
        {
            return _context.imovel.SingleOrDefault(c=>c.id ==id);
        }

        public List<Imovel> GetAll()
        {
            return _context.imovel.ToList();
        }
    }
    
    }

}

    
