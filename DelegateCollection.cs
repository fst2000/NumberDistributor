public class DelegateCollection : ICollection
{
    CollectionDelegate collectionDelegate;

    public DelegateCollection(CollectionDelegate collectionDelegate)
    {
        this.collectionDelegate = collectionDelegate;
    }

    public void Give(IConsumer consumer)
    {
        collectionDelegate(consumer);
    }
}
public delegate void CollectionDelegate(IConsumer consumer);