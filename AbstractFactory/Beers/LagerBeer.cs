namespace AbstractFactory.Beers
{
    public class LagerBeer : IBeer
    {
        public LagerBeer()
        {
            Mashing();
            Boiling();
            Fermentation();
            Separation();
        }

        public void Boiling()
        {
            Console.WriteLine("LAGER: Boiling");
        }

        public void Fermentation()
        {
            Console.WriteLine("LAGER: Fermentation");
        }

        public void Mashing()
        {
            Console.WriteLine("LAGER: Mashing");
        }

        public void Separation()
        {
            Console.WriteLine("LAGER: Separation");
        }
    }
}
