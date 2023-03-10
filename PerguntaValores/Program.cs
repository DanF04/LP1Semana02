using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]);
            int r = Convert.ToInt32(args[1]);
            double pi = Math.PI;
            double V = pi * r ^ 2 * a;
            double Sa = 2 * pi * r * (r + a);

            Console.WriteLine($"Volume = " + V);
            Console.WriteLine($"Area = " + Sa);
        }
    }
}
