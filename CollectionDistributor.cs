public class CollectionDistributor : ICollection
{
    class DistributorConsumer : IConsumer
    {
        IConsumer consumer;
        ConditionDelegate condition;
        public DistributorConsumer(IConsumer consumer, ConditionDelegate condition)
        {
            this.consumer = consumer;
            this.condition = condition;
        }

        public void Consume(int element)
        {
            if(condition(element, 0))
            {
                consumer.Consume(element);
            }
        }
    }
    ICollection collection;
    ConditionDelegate condition;

    public CollectionDistributor(ICollection collection,ConditionDelegate condition)
    {
        this.collection = collection;
        this.condition = condition;
    }
    public void Give(IConsumer consumer)
    {
        collection.Give(new DistributorConsumer(consumer, condition));
    }
    
}