using FunkoPopAPI.MODELS;
using Microsoft.EntityFrameworkCore;

namespace FunkoPopAPI.DATA
{
    public class FunkoPopDbContext : DbContext
    {
        public FunkoPopDbContext(DbContextOptions<FunkoPopDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<FunkoPop> FunkoPops { get; set; }
        public DbSet<Franquicia> Franquicias { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<FranquiciaGenero> FranquiciaGenero { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Sembrado de datos para la clase FunkoPop
            var pop1 = new FunkoPop { ID = 1, Nombre = "Thanos", Descripcion = "Proveniente de Infinity War" };
            var pop2 = new FunkoPop { ID = 2, Nombre = "Marty McFly", Descripcion = "Proveniente de Back to the future" };
            modelBuilder.Entity<FunkoPop>().HasData(new FunkoPop[] { pop1, pop2 });

            // Sembrado de datos para la clase Genero
            var genero1 = new Genero { ID = 1, Descripcion = "Acción" };
            var genero2 = new Genero { ID = 2, Descripcion = "Fantasía" };
            modelBuilder.Entity<Genero>().HasData(new Genero[] { genero1, genero2 });

            // Sembrado de datos para la clase Franquicia
            var franquicia1 = new Franquicia { ID = 1, Nombre = "Marvel" };
            var franquicia2 = new Franquicia { ID = 2, Nombre = "Back to the Future"};
            modelBuilder.Entity<Franquicia>().HasData(new Franquicia[] { franquicia1, franquicia2 });

            var popFranquicia1 = new FunkoPopFranquicia { ID = 1, FunkoPopID = 1, FranquiciaID = 1 };
            var popFranquicia2 = new FunkoPopFranquicia { ID = 2, FunkoPopID = 2, FranquiciaID = 2 };
            modelBuilder.Entity<FunkoPopFranquicia>().HasData(new FunkoPopFranquicia[] { popFranquicia1, popFranquicia2 });

            // Sembrado de datos para la clase FranquiciaGenero
            var franquiciaGenero1 = new FranquiciaGenero { ID = 1, FranquiciaID = 1, GeneroID = 1 };
            var franquiciaGenero2 = new FranquiciaGenero { ID = 2, FranquiciaID = 2, GeneroID = 2 };
            modelBuilder.Entity<FranquiciaGenero>().HasData(new FranquiciaGenero[] { franquiciaGenero1, franquiciaGenero2 });

            base.OnModelCreating(modelBuilder);
        }

    }
}
