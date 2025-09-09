namespace CarBrands.Domain
{
    //Entidad de dominio, referencia con tabla en BD
    public class CarBrand
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Country { get; set; }
    }
}
