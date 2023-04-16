
using AbstractFactory.Clients;
using AbstractFactory.Factories;

IBeerFactory beerFactory = new BeerProduct();
var stoutBeer = new BeerClient(beerFactory, AbstractFactory.Beers.BeerTypeEnum.Stout);
var lagerBeer = new BeerClient(beerFactory, AbstractFactory.Beers.BeerTypeEnum.Lager);


ISoftDrinkFactory softDrinkFactory = new SoftDrinkProduct();
var cola = new SoftdrinkClient(softDrinkFactory, AbstractFactory.Softdrinks.SoftDrinkTypeEnum.Cola);
var orangeSoda = new SoftdrinkClient(softDrinkFactory, AbstractFactory.Softdrinks.SoftDrinkTypeEnum.OrangeSoda);



Console.ReadKey();

