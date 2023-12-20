namespace homework5;

public class Program
{
    public void Main(string[] args)
    {
        #region task1
        var val = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(val % 5 == 0 ? "YES" : "NO");

        #endregion


        #region task2
        var val1 = Convert.ToInt32(Console.ReadLine());
        var val2 = Convert.ToInt32(Console.ReadLine());
        if (val2 < val1)
        {
            (val1, val2) = (val2, val1);
        }
        Console.WriteLine($"{val1} + {val2} = " + (val1+val2));
        Console.WriteLine($"{val1} - {val2} = " + (val2-val1));
        Console.WriteLine($"{val1} * {val2} = " + (val1*val2));
        if (val1 != 0) Console.WriteLine($"{val1} / {val2} = " + (val1/val2));
        else Console.WriteLine("Dividing to Zero Not Permitted!");
        #endregion

        #region task3
        var val3 = Convert.ToInt32(Console.ReadLine());
        var val4 = Convert.ToInt32(Console.ReadLine());
        (val3, val4) = (val4, val3);
        Console.WriteLine($"val3 is {val3}");
        Console.WriteLine($"val4 is {val4}");
        #endregion

        #region task4
        var val5 = Convert.ToInt32(Console.ReadLine());
        for (var i = 1; i < 10; i++)
        {
            Console.WriteLine($"{val5} * {i} = " + (val5*i));
        }
        #endregion

        #region task5
        var val6 = Convert.ToInt32(Console.ReadLine());
        for (var j = 2; j < val6; j=j+2)
        {
            Console.WriteLine(Math.Sqrt(j) + "\n");
        }
        #endregion
    }
}