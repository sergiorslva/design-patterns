using AbstractFactory.Beers;

namespace AbstractFactory.Factories
{
    public class BeerProduct : IBeerFactory
    {
        public IBeer MakeBeer(BeerTypeEnum type)
        {
            switch (type)
            {
                case BeerTypeEnum.Lager: return new LagerBeer();
                case BeerTypeEnum.Stout: return new StoutBeer();
                default: throw new ArgumentException("No type founded");
            }
        }
    }
}
