public class CollectionStatus
{
    ICollection collection;
    public CollectionStatus(ICollection collection)
    {
        this.collection = collection;
    }
    int min = int.MaxValue;
    int max = int.MinValue;
    int sum;
    int count;
    bool hasElement;
    public void Status(StatusDelegate statusDelegate)
    {
        collection.Give(new DelegateConsumer(i =>
        {
            if(i < min) min = i;
            if(i > max) max = i;
            sum += i;
            count++;
            hasElement = true;
        }));
        if(hasElement)
        {
            statusDelegate(min,max,sum/count);
        }
    }
}
public delegate void StatusDelegate(int min, int max, int average);