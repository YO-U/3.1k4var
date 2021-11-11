using System;

namespace _3._1k4var
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Введите число x");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество n");
                int n = int.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 1; i <= n; i++)
                {
                    S += Math.Sin(i * x) / i;
                }
                Console.WriteLine("S={0:F2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
