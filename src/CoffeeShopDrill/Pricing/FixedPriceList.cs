namespace CoffeeShopDrill.Pricing;

// TODO: Implement FixedPriceList (README, step 1).
// Takes one price in its constructor and returns it for every item. This is your fake for testing.
public class FixedPriceList
{
    private readonly decimal _price;
    public FixedPriceList(decimal price)
    {
        _price = price;
    }
}
