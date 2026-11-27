# Coffee Shop Drill: interfaces vs abstract classes

Practice project. Every code file contains only TODO comments; you write all the code.
Time: about 30 to 45 minutes. Target: .NET 10.

## Run it
```
dotnet build
dotnet run --project src/CoffeeShopDrill
dotnet test            # stretch goal
```

## The task

### 1. Interface: swappable behaviour (`Pricing/`)
- `IPriceList` with one method: `decimal GetBasePrice(string itemName)`.
- `MenuPriceList`: real prices from a `Dictionary<string, decimal>`:

  | Item | Base price |
  |---|---|
  | Flat White | R38.00 |
  | Cappuccino | R36.00 |
  | Hot Chocolate | R32.00 |
  | Blueberry Muffin | R30.00 |

  Decide what happens for an item that isn't on the menu.
- `FixedPriceList`: takes one price in its constructor and returns it for every item (your fake).

### 2. Abstract class: shared base with required parts (`Menu/MenuItem.cs`)
- **abstract** property `string Name { get; }`: every child must provide it.
- **abstract** method `decimal CalculatePrice(decimal basePrice)`: every child must provide it.
- **normal** method `decimal RoundToCents(decimal amount)`: 2 decimal places, `MidpointRounding.AwayFromZero`. Shared, not overridable.
- **virtual** method `string Describe(decimal price)`: returns `"{Name}: R{price:0.00}"`. Children may override it.

### 3. Two children (`Menu/`)
- `CoffeeDrink`: takes a name and a size. Price = base price × size factor (Small 1.0, Regular 1.2, Large 1.4), rounded with `RoundToCents`. Model the size as an `enum`.
- `DailySpecial`: R10 off the base price, never below zero. **Overrides** `Describe` to append ` (daily special)`.

### 4. A service that depends on the interface (`Orders/OrderService.cs`)
- Takes an `IPriceList` in its **constructor**.
- `List<string> GetReceipt(IEnumerable<MenuItem> items)`: one `Describe` line per item.
- `decimal GetTotal(IEnumerable<MenuItem> items)`.

### 5. Wire it up (`Program.cs`)
Order a **Large Flat White**, a **Regular Cappuccino** and a **Blueberry Muffin as the daily special**.
1. Print the receipt and total using `MenuPriceList`.
2. Print them again using `FixedPriceList(20m)` **without changing any code inside `OrderService`**.

### Check your output
With `MenuPriceList`:
```
Flat White (Large): R53.20        <- your Name format may differ
Cappuccino (Regular): R43.20
Blueberry Muffin: R20.00 (daily special)
Total: R116.40
```
With `FixedPriceList(20m)`: R28.00, R24.00, R10.00, total R62.00.

## Stretch goals
1. Register `IPriceList` and `OrderService` with `Microsoft.Extensions.DependencyInjection`
   (`dotnet add src/CoffeeShopDrill package Microsoft.Extensions.DependencyInjection`) and resolve `OrderService` from the container.
   Think about which lifetime each should have, and why.
2. Write xUnit tests in `tests/CoffeeShopDrill.Tests` using `FixedPriceList`.

## Afterwards: questions you should be able to answer about your own code
1. Why is `RoundToCents` not virtual?
2. Why does `OrderService` take an `IPriceList` instead of a `MenuPriceList`?
3. What happens if you write `new MenuItem()`? Why?
4. If a new item type comes along (say, a Tea with free refills), what do you change, and what stays the same?
