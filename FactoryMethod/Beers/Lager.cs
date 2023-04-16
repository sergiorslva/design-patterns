namespace FactoryMethod.Beers
{
    public class Lager : IBeer
    {
        public Lager()
        {
            Console.WriteLine("Creating Lager Beer");
        }
    }
}
