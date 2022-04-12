using System;
using System.Globalization;

 class program
{
    static void Main(string[] args)
    {
        double a , raio, n = 3.14159;


        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        a = Math.Pow(raio, 2.0) * n;

   

        Console.WriteLine("A=" + a.ToString("F4",CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
}

