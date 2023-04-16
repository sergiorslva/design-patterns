using FactoryMethod.Beers;

namespace FactoryMethod.Factory
{
    public class BeerFactory : IBeerFactory
    {
        public IBeer CreateBeer(BeerType type)
        {            
            switch (type)
            {
                case BeerType.Lager:
                    {
                        return new Lager();                        
                    }
                case BeerType.Stout:
                    {
                        return new Stout();                       
                    }
                case BeerType.Witbier:
                    {
                        return new Witbier();   
                    }
                default:
                    throw new ArgumentException("Invalid beer type");
            }                    
        }
    }
}
