namespace CarBrands.Application.DTOs
{
    //Clase patron DTO para no exponer las entidades de dominio al cliente
    public class CarBrandDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Country { get; set; }
    }
}

