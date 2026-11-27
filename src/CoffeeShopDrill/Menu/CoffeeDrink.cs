namespace CoffeeShopDrill.Menu;

// TODO: Implement CoffeeDrink (README, step 3).
// A menu item with a size. The price is the base price multiplied by the size factor, rounded with the shared method.
public class CoffeeDrink : MenuItem
{
    public override string Name => throw new NotImplementedException();
    public enum Size
    {
        Small = 1.0,
        Regular = 1.2,
        Large = 1.4
    }

    public override decimal PriceCalculation()
    {
        throw new NotImplementedException();
    }
}
