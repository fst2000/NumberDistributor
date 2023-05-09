public class CollectionStatusPrinter
{
    ICollection collection;
    public CollectionStatusPrinter(ICollection collection)
    {
        this.collection = collection;
    }
    int min = int.MaxValue;
    int max = int.MinValue;
    int sum;
    int count;
    bool hasElement;
    public void Status(IPrinter printer)
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
            printer.Print("\nMin: " + min + "\nMax: " + max + "\nAverage: " + sum/count);
        }
    }
}