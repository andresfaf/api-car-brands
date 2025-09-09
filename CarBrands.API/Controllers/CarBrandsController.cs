using CarBrands.Application.DTOs;
using CarBrands.Application.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace CarBrands.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CarBrandsController : ControllerBase
{
    //Aquí por medio de inyección de dependencias se acceder a metodos del repository
    private readonly ICarBrandsRepository carBrandsRepository;
    public CarBrandsController(ICarBrandsRepository carBrandsRepository)
    {
        this.carBrandsRepository = carBrandsRepository;
    }

    //Endpoint para recuperar todos los datos de la tabla CarBrands
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var carBrands = await carBrandsRepository.GetAll();
        //Mapeo usando libreria Mapster para exponer el DTO
        var carBrandsDto = carBrands.Adapt<CarBrandDto>();
        return Ok(carBrandsDto);
    }
}
