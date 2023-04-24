public class ConsolePrinter : IPrinter
{
    public void Print(string text)
    {
        Console.SetCursorPosition(0,Console.CursorTop);
        Console.Write(text);
    }
}