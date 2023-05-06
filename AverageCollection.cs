public class AverageCollection : ICollection
{
    class AverageConsumer : IConsumer
    {
        public AverageConsumer(IConsumer consumer)
        {
            this.consumer = consumer;
        }
        public IConsumer consumer;
        bool hasElement;
        int sum = 0;
        int count = 0;
        public void Consume(int element)
        {
            hasElement = true;
            sum += element;
            count++;
        }
        public void Give(IConsumer consumer)
        {
            if(hasElement) consumer.Consume(sum / count);
        }
    }
    ICollection collection;

    public AverageCollection(ICollection collection)
    {
        this.collection = collection;
    }

    public void Give(IConsumer consumer)
    {
        var minMaxAverageConsumer = new AverageConsumer(consumer);
        collection.Give(minMaxAverageConsumer);
        minMaxAverageConsumer.Give(consumer);
    }
}