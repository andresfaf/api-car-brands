using FluentAssertions;
using CarBrands.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using CarBrands.Domain;
using CarBrands.Application.Interfaces;
using CarBrands.Infrastructure.Repositories;
using System.Timers;

public class CarBrandsControllerTests
{
    private readonly CarBrandsController _controller;

    public CarBrandsControllerTests()
    {
        var context = ApplicationDbContextTest.GetInMemoryDbContext();
        ICarBrandsRepository repo = new CarBrandsRepository(context);

        _controller = new CarBrandsController(repo);
    }

    [Fact]
    public async Task GetAll()
    {
        var result = await _controller.GetAll();

        var okResult = result as OkObjectResult;
        okResult.Should().NotBeNull();

        var brands = okResult!.Value as IEnumerable<CarBrand>;
        brands.Should().NotBeNull();
        brands!.Count().Should().Be(3); //Deberia retornar 3 datos
        brands!.First().Name.Should().Be("Toyota"); // El primer dato deberia ser Toyota
    }
}
