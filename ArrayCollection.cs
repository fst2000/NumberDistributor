public class ArrayCollection : ICollection
{
    int[] array;

    public ArrayCollection(int[] array)
    {
        this.array = array;
    }

    public void Give(IConsumer consumer)
    {
        foreach(int a in array) consumer.Consume(a);
    }
}