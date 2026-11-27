 namespace CoffeShopDrill.Menu;

 public static class DrinkSize
{
    public enum DrinkSizes
    {
        Small,
        Regular,
        Large
    }
    public static double SizeMultiplier(this DrinkSizes size) => size switch
    {
        DrinkSizes.Small => 1.0,
        DrinkSizes.Regular => 1.2,
        DrinkSizes.Large => 1.4,
        _ => throw new ArgumentOutOfRangeException(nameof(size), size, "Unknown Size")
    };

}
