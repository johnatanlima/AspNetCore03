using AspCore03.Models;
using Microsoft.EntityFrameworkCore;

namespace AspCore03.Data{
    public class EscolaDbContext : DbContext
    {
        public EscolaDbContext(DbContextOptions<EscolaDbContext> options) : base(options){

        }
        
        //public EscolaDbContext()
        public DbSet<Escola> Escolas {get; set;}
    }
}