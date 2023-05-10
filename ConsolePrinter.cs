public class ConsolePrinter : ITextPrinter
{
    public void Print(string text)
    {

        Console.WriteLine(text);
    }
}