class Program
{
    static void Main(string[] args)
    {
        int[] array = args.Select(int.Parse).ToArray();
        IPrinter printer = new ConsolePrinter();
        IDistributor distributor = new NumberDistributor(array);
        distributor.Distribute(printer);
        distributor.Below().Distribute(printer);
        distributor.Above().Distribute(printer);

    }
}