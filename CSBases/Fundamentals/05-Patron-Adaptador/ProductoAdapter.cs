using CSBases.Fundamentals;

public class ProductAdapter
{
    public static ProductoDto ToDto(Product product)
    {
        return new ProductoDto
        {
            Name = product.Name ?? "Sin nombre",
            Price = product.Price,
            Code = $"P-{product.Id}-{product.UniqueCode.ToString().Substring(0, 8)}"
        };
    }
}