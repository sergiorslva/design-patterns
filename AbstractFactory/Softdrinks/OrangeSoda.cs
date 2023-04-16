namespace AbstractFactory.Softdrinks
{
    public class OrangeSoda : ISoftdrink
    {
        public OrangeSoda()
        {
            Carbonation();
            FlavouringSyrup();
        }
        public void Carbonation()
        {
            Console.WriteLine("ORANGE SODA: Carbonation");
        }

        public void FlavouringSyrup()
        {
            Console.WriteLine("ORANGE SODA: FlavouringSyrup");
        }
    }
}
