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
            modelBuilder.ApplyConfiguration(new Roles());
        }

        public DbSet<Espositore> Espositori { get ; set; }
        public DbSet<Azienda> Aziende { get ; set; }
        public DbSet<Prodotto> Prodotti { get ; set; }
        public DbSet<Stand> Stands { get ; set; }
        public DbSet<Visitatore> Visitatori { get ; set; }
       
    }
}