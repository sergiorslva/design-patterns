namespace AbstractFactory.Beers
{
    public class StoutBeer : IBeer
    {
        public StoutBeer()
        {
            Mashing();
            Boiling();
            Fermentation();
            Separation();
        }

        public void Boiling()
        {
            Console.Write("STOUT: Boiling\n");
        }

        public void Fermentation()
        {
            Console.Write("STOUT: Fermentation\n");
        }

        public void Mashing()
        {
            Console.Write("STOUT: Mashing\n");
        }

        public void Separation()
        {
            Console.Write("STOUT: Separation\n");
        }
    }
}
