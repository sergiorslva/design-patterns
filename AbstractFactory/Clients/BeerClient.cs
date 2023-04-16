using AbstractFactory.Beers;
using AbstractFactory.Factories;

namespace AbstractFactory.Clients
{
    public class BeerClient
    {
        private IBeer beer;
        public BeerClient(IBeerFactory factory, BeerTypeEnum type)
        {
            beer = factory.MakeBeer(type);
        }
    }
}
