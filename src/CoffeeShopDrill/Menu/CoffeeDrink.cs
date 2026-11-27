namespace CoffeeShopDrill.Menu;

// TODO: Implement CoffeeDrink (README, step 3).
// A menu item with a size. The price is the base price multiplied by the size factor, rounded with the shared method.
public class CoffeeDrink : MenuItem
{
    public override string Name => throw new NotImplementedException();
    public enum Size
    {
        Small,
        Regular,
        Large
    }

    private static double SizeMultiplier(this Size size) => size switch
    {
        Size.Small => 1.0,
        Size.Regular => 1.2,
        Size.Large => 1.4,
        _ => throw new ArgumentOutOfRangeException(nameof(size), size, "Unknown Size")
    };

    public override decimal PriceCalculation()
    {
        
    }
}
