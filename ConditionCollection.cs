public class ConditionCollection : ICollection
{
    ICollection collection;
    CondiitonDelegate condition;

    public ConditionCollection(ICollection collection, CondiitonDelegate condition)
    {
        this.collection = collection;
        this.condition = condition;
    }

    public void Give(IConsumer consumer)
    {
        collection.Give(new DelegateConsumer(i =>
        {
            if(condition(i))consumer.Consume(i);
        }));
    }
}
public delegate bool CondiitonDelegate(int element);