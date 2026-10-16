using System;

namespace CSBases.Fundamentals;

public class Product : IProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid UniqueCode { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        CreatedAt = DateTime.Now;
        UniqueCode = Guid.NewGuid();
    }

    public void ApplyDiscount(decimal percentage)
    {
        var discountAmount = (Price * percentage) / 100;
        Price -= discountAmount;
    }

    public virtual string GetDescription()
    {
        return $"* {Name} - Precio: {Price:C}";
    }
}

class ServiceProduct : Product
{
    public int DurationInDays { get; set; }

    public ServiceProduct(string name, decimal price, int durationInDays)
        : base(name, price)
    {
        DurationInDays = durationInDays;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Duración: {DurationInDays} días";
        // return $"Servicio: {Name}, Precio: {Price:C}, Duración: {DurationInDays} horas";
    }
}