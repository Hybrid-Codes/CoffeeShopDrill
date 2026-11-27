namespace CoffeeShopDrill.Pricing;
// TODO: Implement MenuPriceList (README, step 1).
// Real prices held in a Dictionary. Decide what happens when an item isn't on the menu.

public class MenuPriceList : IPriceList
{
    private static readonly Dictionary<string, decimal> Prices = new()
    {
            {"Flat White", 38.00m},
            {"Cappuccino", 36.00m},
            {"Hot Chocolate", 32.00m},
            {"Blueberry Muffin", 30.00m}
    }
    public decimal GetBasePrice (string itemName)
    {


        if (!Prices.TryGetValue(itemName, out var item))
        {
            throw new ArgumentException($"{itemName} is not on the menu.");
        }

        return Prices[itemName];

    }

    public MenuPriceList FixedPriceList()
    {

    }
}
