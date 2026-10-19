using CSBases.Fundamentals;

public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        // Obtener de una base de datos, 
        // una llamada a una API externa 
        // o podría ser de un archivo
        WriteLine("Buscando producto...");
        await Task.Delay(2000);
        return new Product("Producto Simulado", 500m);
    }
}