using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int TriSize = Convert.ToInt32(args[0]);

            string x = args[1];

            for (int i = 0; i < TriSize; i++)
            { 
               x += args[1];
               Console.WriteLine(x);
            }
        }
    }
}
