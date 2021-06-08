using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SalonedelGusto.Models
{
    public class DBContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;
        public DBContext(){}

        protected override void 
                OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=SaloneDelGusto.db");

        public DBContext(DbContextOptions options): base(options)
        {
            _options = options; 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Espositore> Espositore { get ; set; }
        public DbSet<Azienda> Azienda { get ; set; }
        public DbSet<Prodotto> Prodotto { get ; set; }
        public DbSet<Stand> Stand { get ; set; }
        public DbSet<Visitatore> Visitatore { get ; set; }
       
    }
}