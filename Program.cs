using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        ConditionDelegate condition = delegate (int i, int compareTo) { return i < compareTo;};
        new CollectionDistributor(new ArrayCollection(args.Select(int.Parse).ToArray()), condition).Give(new ConsoleConsumer());
    }
}