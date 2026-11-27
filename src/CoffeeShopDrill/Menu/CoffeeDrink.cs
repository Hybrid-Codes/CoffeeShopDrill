using System.Drawing;

namespace CoffeeShopDrill.Menu;

// TODO: Implement CoffeeDrink (README, step 3).
// A menu item with a size. The price is the base price multiplied by the size factor, rounded with the shared method.
public class CoffeeDrink : MenuItem
{
    public override string Name => _name;
    private readonly string _name;
    private readonly DrinkSizes _size;

    public CoffeeDrink(string name, DrinkSizes size)
    {
        _name = name;
        _size = size;
    }

    public override decimal CalculatePrice(decimal basePrice)
    {
        decimal price = basePrice * DrinkSizeExtensions.SizeMultiplier(_size);
        return base.RoundToCents(price);
    }

    public override string Describe(decimal price)
    {
        return $"{Name} ({_size}): R{price: 00.00}";
    }
}
