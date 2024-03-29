using System.Collections.Generic;
using System.Linq;
using aula13crudPeople.Models.Data;
using aula13crudPeople.Models.Entities;

namespace aula13crudPeople.Models.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        private DataContext context;
        public PersonRepository(DataContext context){
            this.context = context;
        }

        public void Create(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAll()
        {
           return context.People.ToList();
        }

        public void GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}