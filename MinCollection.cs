public class MinCollection : ICollection
{
    class MinConsumer : IConsumer
    {
        int min = int.MaxValue;
        bool hasMin;
        public void Consume(int element)
        {
            if(min > element) min = element;
            hasMin = true;
        }
        public void Give(IConsumer consumer)
        {
            if(hasMin) consumer.Consume(min);
        }
    }
    ICollection collection;
    public MinCollection(ICollection collection)
    {
        this.collection = collection;
    }
    public void Give(IConsumer consumer)
    {
        var minSearcherConsumer = new MinConsumer();
        collection.Give(minSearcherConsumer);
        minSearcherConsumer.Give(consumer);
    }

}