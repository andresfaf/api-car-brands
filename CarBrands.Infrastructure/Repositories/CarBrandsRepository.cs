using CarBrands.Application.Interfaces;
using CarBrands.Domain;
using CarBrands.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace CarBrands.Infrastructure.Repositories
{
    //Implementación de los contratos del patron repository
    public class CarBrandsRepository : ICarBrandsRepository
    {
        private readonly ApplicationDbContext context;

        public CarBrandsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<CarBrand>> GetAll()
        {
            try
            {
                //Aqui se usa entity framework core para accerder a la base de datos
                return await context.CarBrands.ToListAsync();
            }
            catch (NpgsqlException ex)
            {
                //Execpción de BD Postgres
                throw new NpgsqlException("Error en la recuperación de las marcas de carros", ex);
            }
        }
    }
}
