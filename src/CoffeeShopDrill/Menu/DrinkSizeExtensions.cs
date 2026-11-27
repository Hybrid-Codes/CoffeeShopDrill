namespace CoffeeShopDrill.Menu;


public static class DrinkSizeExtensions
{
    public static decimal SizeMultiplier(this DrinkSizes size) => size switch
    {
        DrinkSizes.Small => 1.0m,
        DrinkSizes.Regular => 1.2m,
        DrinkSizes.Large => 1.4m,
        _ => throw new ArgumentOutOfRangeException(nameof(size), size, "Unknown Size")
    };

}
    public enum DrinkSizes
    {
        Small,
        Regular,
        Large
    }
