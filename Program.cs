using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var array = args.Select(int.Parse).ToArray();
        new CollectionStatusPrinter(new ArrayCollection(array)).Status(new ConsolePrinter());

    }
}