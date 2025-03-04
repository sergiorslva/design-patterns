namespace Prototype
{
    public interface ICloneable
    {
        PersonModel Clone();
        PersonModel DeepClone();
    }
}
