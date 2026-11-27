using CoffeShopDrill.Menu;
using static CoffeShopDrill.Menu.DrinkSize;

namespace CoffeeShopDrill.Menu;

// TODO: Implement CoffeeDrink (README, step 3).
// A menu item with a size. The price is the base price multiplied by the size factor, rounded with the shared method.
public class CoffeeDrink : MenuItem
{
    public override string Name => throw new NotImplementedException();


    public override decimal PriceCalculation(decimal basePrice)
    {
        decimal price = basePrice * DrinkSize.SizeMultiplier();
        return price;
    }
}

