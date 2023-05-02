public class ConsoleConsumer : IConsumer
{
    public void Consume(int element)
    {
        Console.WriteLine(element);
    }
}