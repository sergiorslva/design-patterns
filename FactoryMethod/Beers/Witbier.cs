namespace FactoryMethod.Beers
{
    public class Witbier : IBeer
    {
        public Witbier()
        {
            Console.WriteLine("Creating Witbier Beer");
        }
    }
}
