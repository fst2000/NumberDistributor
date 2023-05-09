public class ConsoleCollectionStatus : ICollectionStatus
{
    int min = int.MaxValue;
    int max = int.MinValue;
    int sum;
    int count;
    bool hasElement;
    public void Status(ICollection collection)
    {
        collection.Give(new DelegateConsumer(i =>
        {
            if(i < min) min = i;
            if(i > max) max = i;
            sum += i;
            count++;
            hasElement = true;
        }));
        IConsumer consumer = new ConsoleConsumer();
        if(hasElement)
        {
            consumer.Consume(sum/count);
            consumer.Consume(min);
            consumer.Consume(max);
        }
    }
}