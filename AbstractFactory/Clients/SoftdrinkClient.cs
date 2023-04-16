using AbstractFactory.Factories;
using AbstractFactory.Softdrinks;

namespace AbstractFactory.Clients
{
    public class SoftdrinkClient
    {
        private ISoftdrink softDrink;
        public SoftdrinkClient(ISoftDrinkFactory factory, SoftDrinkTypeEnum type)
        {
            softDrink = factory.MakeSoftDrink(type);
        }
    }
}
