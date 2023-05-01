public class ConsolePrinter<T> : IPrinter<T>
{
    public void Print(T text)
    {
        if(text != null)
        {
            Console.SetCursorPosition(0,Console.CursorTop);
            Console.Write(text.ToString());
        }
    }
}