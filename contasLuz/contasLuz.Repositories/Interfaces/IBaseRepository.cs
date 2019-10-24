using System.Collections.Generic;

namespace contasLuz.Repositories.Interfaces
{
    public interface IBaseRepository<Entity>
    where Entity : class
    {
         
         void Create(Entity entity);
         void Update (Entity entity);
         void Delete (int id);
         Entity GetByID(int id);
    
        List<Entity> GetAll ();
    }
}