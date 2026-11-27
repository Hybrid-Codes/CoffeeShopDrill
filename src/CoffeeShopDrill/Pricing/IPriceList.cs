namespace CoffeeShopDrill.Pricing;

// TODO: Define the IPriceList interface (README, step 1).
// It should expose one method that returns the base price for a menu item, looked up by the item's name.
public interface IPriceList
{
    decimal GetBasePrice(string itenName);
}
