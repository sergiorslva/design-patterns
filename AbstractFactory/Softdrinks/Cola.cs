namespace AbstractFactory.Softdrinks
{
    public class Cola : ISoftdrink
    {
        public Cola()
        {
            Carbonation();
            FlavouringSyrup();
        }
        public void Carbonation()
        {
            Console.WriteLine("COLA: Carbonation");
        }

        public void FlavouringSyrup()
        {
            Console.WriteLine("COLA: FlavouringSyrup");
        }
    }
}
