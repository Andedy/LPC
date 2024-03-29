using aula13crudPeople.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace aula13crudPeople.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }

        public DbSet<Person> People {get; set;}
        public int MyProperty { get; set; }
        
    }
}