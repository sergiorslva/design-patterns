using AbstractFactory.Softdrinks;

namespace AbstractFactory.Factories
{
    public interface ISoftDrinkFactory
    {
        ISoftdrink MakeSoftDrink(SoftDrinkTypeEnum type);        
    }
}
