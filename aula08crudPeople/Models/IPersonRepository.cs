using System.Collections.Generic;

namespace aula08crudPeople.Models
{
    public interface IPersonRepository
    {
         void Create(Person person);
         void Update (Person person);
         void Delete (int id);
         void GetByID(int id);
    
        List<Person> GetAll ();
    }
}