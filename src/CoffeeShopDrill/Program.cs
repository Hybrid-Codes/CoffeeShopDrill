using System.IO.Pipelines;
using CoffeeShopDrill.Menu;
using CoffeeShopDrill.Orders;
using CoffeeShopDrill.Pricing;
using Microsoft.Extensions.DependencyInjection;

// 1. Register: tell the container which class to hand out for each type
var services = new ServiceCollection();
services.AddScoped<IPriceList, MenuPriceList>();
services.AddScoped<IPriceList, OrderService>();
// TODO: register OrderService (pick its lifetime)

// 2. Build the container
using var provider = services.BuildServiceProvider();
using var scope = provider.CreateScope();

// 3. Ask for an OrderService. The container builds it and passes a MenuPriceList into its constructor.
var orderService = scope.ServiceProvider.GetRequiredService<OrderService>();

// TODO 1: build the order
// TODO 2: print the receipt lines and the total


// var drink = new CoffeeDrink("Flat White", DrinkSizes.Large);
// var result = drink.CalculatePrice(38m);
// Console.WriteLine(drink.Describe(result));   // should print 53.20
