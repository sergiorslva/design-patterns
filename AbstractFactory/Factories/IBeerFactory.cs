using AbstractFactory.Beers;

namespace AbstractFactory.Factories
{
    public interface IBeerFactory
    {
        IBeer MakeBeer(BeerTypeEnum type);        
    }
}
