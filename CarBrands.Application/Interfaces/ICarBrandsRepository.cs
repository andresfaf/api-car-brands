using CarBrands.Domain;

namespace CarBrands.Application.Interfaces
{
    //Contratos del patron repository
    public interface ICarBrandsRepository
    {
        Task<List<CarBrand>> GetAll();
    }
}
