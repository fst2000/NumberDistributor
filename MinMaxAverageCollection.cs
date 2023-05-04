public class MinMaxAverageCollection : ICollection
{
    class MinMaxAverageConsumer : IConsumer
    {
        public MinMaxAverageConsumer(IConsumer consumer)
        {
            this.consumer = consumer;
        }
        public IConsumer consumer;
        bool hasMin;
        bool hasMax;
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        int count = 0;
        public void Consume(int element)
        {
            if(min > element) min = element;
            if(max < element) max = element;
            hasMin = true;
            hasMax = true;
            sum += element;
            count++;
        }
        public void Give(IConsumer consumer)
        {
            if(hasMin)consumer.Consume(min);
            if(hasMax)consumer.Consume(max);
            consumer.Consume(sum / count);
        }
    }
    ICollection collection;

    public MinMaxAverageCollection(ICollection collection)
    {
        this.collection = collection;
    }

    public void Give(IConsumer consumer)
    {
        var minMaxAverageConsumer = new MinMaxAverageConsumer(consumer);
        collection.Give(minMaxAverageConsumer);
        minMaxAverageConsumer.Give(consumer);
    }
}