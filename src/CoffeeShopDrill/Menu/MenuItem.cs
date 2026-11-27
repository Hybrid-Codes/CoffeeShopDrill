using System.ComponentModel.DataAnnotations;
using System.Runtime;

namespace CoffeeShopDrill.Menu;

// TODO: Define the abstract MenuItem base class (README, step 2).
// Needs: an abstract Name, an abstract price calculation, a normal (non-virtual) rounding method,
// and a virtual Describe method that children may override.
public abstract class MenuItem
{
    public abstract string Name { get; }

    public abstract decimal CalculatePrice(decimal basePrice);

    public decimal RoundToCents(decimal amount)
    {
        return Math.Round(amount, 2, MidpointRounding.AwayFromZero);
    }

    public virtual string Describe(decimal price)
    {
        return $"{Name}: R{price:0.00}";
    }
}
