using CSBases.Fundamentals;

public class LaberService : ILabelService
{
    public string GenerateLabel(Product product)
    {
        return $"{product.Name} - Precio: {product.Price:C} - Etiqueta: {product.GetType().Name}-{product.GetHashCode()}";
    }
}