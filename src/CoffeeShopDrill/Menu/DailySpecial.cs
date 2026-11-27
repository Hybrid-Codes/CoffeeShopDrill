namespace CoffeeShopDrill.Menu;

// TODO: Implement DailySpecial (README, step 3).
// R10 off the base price (never below zero). Overrides Describe to add "(daily special)".

public class DailySpecial : MenuItem
{
    public override string Name => "Daily Special";

    public override decimal CalculatePrice(decimal basePrice)
    {
        if (basePrice >= 0)
        {
            Describe(basePrice);
        }

        return basePrice;
    }

    public override string Describe(decimal price)
    {
        return $"{Name}: R{price}";
    }
}
