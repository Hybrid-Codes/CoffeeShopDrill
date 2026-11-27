using System.IO.Pipelines;

namespace CoffeeShopDrill.Menu;

// TODO: Implement DailySpecial (README, step 3).
// R10 off the base price (never below zero). Overrides Describe to add "(daily special)".

public class DailySpecial : MenuItem
{
    public override string Name => _name;

    private readonly string _name;
    private readonly decimal _discount;

    public DailySpecial(string name, decimal discount)
    {
        _name = name;
        _discount = discount;
    }

    public override decimal CalculatePrice(decimal basePrice)
    {
        decimal result = basePrice - _discount;

        if(result < 0)
        {
            return 0;
        }

        return base.RoundToCents(result);
    }

    public override string Describe(decimal price)
    {
        string? result = base.Describe(price);
        return $"{result} (daily special)";
    }
}
