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
            
            //Removed 1 from the variable
            Console.WriteLine ($"{--n}");
            //Added 1 to the variable
            Console.WriteLine ($"{++n}");

        }
    }
}
