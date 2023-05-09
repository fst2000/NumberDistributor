public class DelegateConsumer : IConsumer
{
    ConsumerDelegate consumerDelegate;

    public DelegateConsumer(ConsumerDelegate consumerDelegate)
    {
        this.consumerDelegate = consumerDelegate;
    }

    public void Consume(int element)
    {
        consumerDelegate(element);
    }
}
public delegate void ConsumerDelegate(int item);