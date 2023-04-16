namespace AbstractFactory.Beers
{
    public interface IBeer
    {
        public void Mashing();
        public void Separation();
        public void Boiling();
        public void Fermentation();
    }
}
