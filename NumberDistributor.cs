using System.Collections.Generic;
public class NumberDistributor : IDistributor
{
    int[] array;
    int average;
    int min;
    int max;
    public NumberDistributor(int[] array)
    {
        this.array = array;
        Iteration();
    }
    public void Distribute(IPrinter printer)
    {
        printer.Print("Average: " + array.Sum() / array.Length + "\n" + "Max: " + array.Max() + "\n" + "Min:" + array.Min() + "\n");
    }
    public IDistributor Below()
    {
        int length = 0;
        int[] arrayBelow;
        foreach(var a in array)
        {
            length += a <= average? 1 : 0;
        }
        arrayBelow = new int[length];
        int counter = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] <= average)
            {
                arrayBelow[counter] = array[i];
                counter ++;
            }
        }
        return new NumberDistributor(arrayBelow);
    }
    public IDistributor Above()
    {
        int length = 0;
        int[] arrayBelow;
        foreach(var a in array)
        {
            length += a >= average? 1 : 0;
        }
        arrayBelow = new int[length];
        int counter = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] >= average)
            {
                arrayBelow[counter] = array[i];
                counter ++;
            }
        }
        return new NumberDistributor(arrayBelow);
    }
    void Iteration()
    {
        int sum = 0;
        foreach(var a in array)
        {
            min = a < min? a : min;
            max = a > max? a : max;
            sum += a;
        }
        average = sum / array.Length;
    }
}