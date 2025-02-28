using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere a altura do cilindro");
            string altura = Console.ReadLine();
            Console.WriteLine("Insere o raio do cilindro");
            string raio = Console.ReadLine();

            double a = double.Parse(altura);
            double r = double.Parse(raio);

            double V = Math.PI * Math.Pow(r,2) * a;
            double Sa = 2 * Math.PI * r * (r + a);

            Console.WriteLine($"{V:f3}");
            Console.WriteLine($"{Sa:f3}");


        }   
    }
}
