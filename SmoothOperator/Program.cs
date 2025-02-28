using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {

            //Asks for user input
            Console.WriteLine("Insere um número inteiro:");
            string smoo = Console.ReadLine();
            
            //Converts user input into an sbyte
            sbyte n = sbyte.Parse(smoo);

            Console.WriteLine ($"{--n}");
            Console.WriteLine ($"{++n}");

        }
    }
}
