public class LessThanCollection : ICollection
{
    class LessThanConsumer : IConsumer
    {
        IConsumer consumer;
        int lessThan;

        public LessThanConsumer(IConsumer consumer, int lessThan)
        {
            this.consumer = consumer;
            this.lessThan = lessThan;
        }

        public void Consume(int element)
        {
            if(element < lessThan)
            {
                consumer.Consume(element);
            }
        }
    }
    ICollection collection;
    int lessThan;

    public LessThanCollection(ICollection collection, int lessThan)
    {
        this.collection = collection;
        this.lessThan = lessThan;
    }

    public void Give(IConsumer consumer)
    {
        collection.Give(new LessThanConsumer(consumer, lessThan));
    }
}
