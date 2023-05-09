using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var array = args.Select(int.Parse).ToArray();
        new ConsoleCollectionStatus().Status(new ArrayCollection(array));

    }
}