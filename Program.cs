using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        StatusDelegate minMaxAveragePrint = (min,max,average) => 
        {
            Console.WriteLine("Min : {0}\nMax: {1}\nAverage: {2}", min.ToString(), max.ToString(), average.ToString());
        };
        var array = args.Select(int.Parse).ToArray();
        ICollection collection = new ArrayCollection(array);
        new CollectionStatus(collection).Status((min,max,average) =>
        {
            minMaxAveragePrint(min,max,average);
            new CollectionStatus(new ConditionCollection(collection,i => i <= average)).Status(minMaxAveragePrint);
            new CollectionStatus(new ConditionCollection(collection,i => i >= average)).Status(minMaxAveragePrint);
        });
    }
}