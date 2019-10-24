using System.Collections.Generic;

namespace aula13crudPeople.Models.Repositories
{
    public interface IBaseRepository<Entity>
    where Entity : class
    {
         
         void Create(Entity entity);
         void Update (Entity entity);
         void Delete (int id);
         void GetByID(int id);
    
        List<Entity> GetAll ();
    }
}