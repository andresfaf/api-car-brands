using CarBrands.Domain;
using Microsoft.EntityFrameworkCore;

//Contexto de la aplicación con relación a la base de datos
namespace CarBrands.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Tabla en base de datos que se generara automaticamente con la migración
        public DbSet<CarBrand> CarBrands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Data seed - Datos por defecto insertados en la BD al arrancar el programa
            modelBuilder.Entity<CarBrand>().HasData(
                new CarBrand { Id = 1, Name = "Toyota", Country = "Japón" },
                new CarBrand { Id = 2, Name = "Ford", Country = "Estados Unidos" },
                new CarBrand { Id = 3, Name = "BMW", Country = "Alemania" }
            );
        }
    }
}
