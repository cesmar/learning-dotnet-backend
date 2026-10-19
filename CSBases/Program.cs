using CSBases.Fundamentals;

class Program
{
    static async Task Main()
    {
        var laptop = new Product("Laptop", 1200m);
        // WriteLine(laptop.GetDescription());

        var soport = new ServiceProduct("Soporte Técnico", 300m, 30);
        // WriteLine(soport.GetDescription());

        var product = new Product("Mouse game", 300m);
        var productDto = ProductAdapter.ToDto(product);
        // WriteLine($"- {productDto.Name}, Precio: {productDto.Price}, Código: {productDto.Code}");


        //Inyección de dependencias
        ILabelService labelService = new LaberService();
        var manager = new ProductManager(labelService);

        var monitor = new Product("Monitor", 250m);
        var installation = new ServiceProduct("Instalación de monitor", 20m, 30);
        // manager.PrintLabel(monitor);
        // manager.PrintLabel(installation);

        var firstProduct = await new ProductRepository().GetProduct(1);
        firstProduct.Description = "Esta es la descripción del primer producto";
        AttributeProcessor.ApplyUpperCase(firstProduct);
        WriteLine($"{firstProduct.Name} - {firstProduct.Price:C} - {firstProduct.Description}");
    }
}
