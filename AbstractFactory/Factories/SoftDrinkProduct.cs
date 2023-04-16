using AbstractFactory.Softdrinks;

namespace AbstractFactory.Factories
{
    public class SoftDrinkProduct : ISoftDrinkFactory
    {
        public ISoftdrink MakeSoftDrink(SoftDrinkTypeEnum type)
        {
            switch(type)
            {
                case SoftDrinkTypeEnum.Cola: return new Cola();
                case SoftDrinkTypeEnum.OrangeSoda: return new OrangeSoda();
                default: throw new ArgumentException("No type founded");
            }
        }
    }
}
