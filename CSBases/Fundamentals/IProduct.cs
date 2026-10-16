using System;

namespace CSBases.Fundamentals;

public interface IProduct
{
    void ApplyDiscount(decimal percentage);
    string GetDescription();
}
