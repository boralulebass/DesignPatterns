namespace DesignPattern.IteratorPattern.IteratorPattern
{
    public interface IMover<T>
    {
        Iterator<T> CreateIterator();

    }
}
