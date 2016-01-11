using System;

public class FtoCTable
{
    public FtoCTable()
    {
    }

    static void Main()
    {
        double f, c;

        for (f = 0.0; f < 100.0; f++)
        {
            // 摂氏に変換
            c = 5.0 / 9.0 * (f - 32.0);
            Console.WriteLine(f + " degrees Fatrenheit is " + c + " degrees Celsius.");
        }
    }
}
