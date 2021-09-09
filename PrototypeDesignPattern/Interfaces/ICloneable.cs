namespace PrototypeDesignPattern.Interfaces
{
    public interface ICloneable
    {
        object ShallowCopy();
        object DeepCopy();
    }
}