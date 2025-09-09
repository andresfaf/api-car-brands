using Microsoft.EntityFrameworkCore;
using CarBrands.Domain;
using CarBrands.Infrastructure.Data;

//Db context para simular una BD real
public static class ApplicationDbContextTest
{
    public static ApplicationDbContext GetInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new ApplicationDbContext(options);

        // Datos manuales para pruebas
        context.CarBrands.AddRange(
            new CarBrand { Id = 1, Name = "Toyota", Country = "Japón" },
            new CarBrand { Id = 2, Name = "Ford", Country = "Estados Unidos" },
            new CarBrand { Id = 3, Name = "BMW", Country = "Alemania" }
        );
        context.SaveChanges();

        return context;
    }
}
