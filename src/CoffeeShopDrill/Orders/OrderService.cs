using CoffeeShopDrill.Pricing;

namespace CoffeeShopDrill.Orders;

// TODO: Implement OrderService (README, step 4).
// Depends on IPriceList through its constructor. Produces receipt lines and a total for a list of menu items.
internal class OrderService : IPriceList
{
    public decimal GetBasePrice(string itenName)
    {
        throw new NotImplementedException();
    }
}
