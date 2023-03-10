using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Insert height:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Insert radius:");
            int r = Convert.ToInt32(Console.ReadLine());
            double pi = Math.PI;
            double V = pi * (r * r) * a;
            double Sa = 2 * pi * r * (r + a);

            Console.WriteLine($"Volume = " + V);
            Console.WriteLine($"Area = " + Sa);
        }
    }
}
