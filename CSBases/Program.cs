using CSBases.Fundamentals;

class Program
{
    static void Main()
    {
        // WriteLine("Hello, World!");
        //Declaración explícita
        int quantity = 10;
        string message = "Hello, World!";
        decimal price = 14.99m;
        // WriteLine($"Cantidad: {quantity}, Saludo: {message}, Precio: {price:C}");

        //Declaración implícita (con var)
        var greeting = "Hola";
        var percentage = 20.00m;
        // WriteLine($"Saludo: {greeting}, Porcentaje: {percentage:P}");

        var laptop = new Product("Laptop", 1200m);
        WriteLine(laptop.GetDescription());

        var soport = new ServiceProduct("Soporte Técnico", 300m, 30);
        WriteLine(soport.GetDescription());
    }
}
