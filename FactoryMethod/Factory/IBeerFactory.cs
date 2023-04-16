using FactoryMethod.Beers;

namespace FactoryMethod.Factory
{
    public interface IBeerFactory
    {
        public IBeer CreateBeer(BeerType type);
    }
}
