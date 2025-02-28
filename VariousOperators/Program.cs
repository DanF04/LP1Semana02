using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {

            //Aks for the user input
            Console.WriteLine("Insere um número-não negativo:");
            string intn = Console.ReadLine();

            //Converts user input into an sbyte
            byte n = byte.Parse(intn);

            //Divides the variable by 2
            Console.WriteLine($"{n/2}");
            //Shifts the variable by 3
            Console.WriteLine($"{n<<3}");
            //XOR by 6
            Console.WriteLine($"{n^6}");
            //Gives true if the variable is bigger than 10
            Console.WriteLine($"{n>10}");
        }
    }
}
