using FactoryMethod.Beers;
using FactoryMethod.Factory;

BeerFactory creator = new BeerFactory();

IBeer beer = creator.CreateBeer(BeerType.Witbier);
Console.WriteLine($"{beer} has been created");

Console.ReadKey();