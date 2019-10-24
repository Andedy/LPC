using Microsoft.EntityFrameworkCore;
using contasLuz.Domain;

namespace contasLuz.Repositories.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options)
                :base(options){

        }

        public  DbSet<Conta> contaLuz { get; set; }
    }
}