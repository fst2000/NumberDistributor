using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        new MinMaxAverageCollection(new ArrayCollection(args.Select(int.Parse).ToArray())).Give(new ConsoleConsumer());
    }
}