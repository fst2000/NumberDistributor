public class ArrayCollection<T> : ICollection<T>
{
    T[] array;

    public ArrayCollection(T[] array)
    {
        this.array = array;
    }

    public void Read(IReader<T> reader)
    {
        foreach(T a in array) reader.Read(a);
    }
}