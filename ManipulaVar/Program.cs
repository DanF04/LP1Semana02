using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int x = Convert.ToInt32(args[0]);
            int xx = x;
            int xy = x;
            xx++;
            --xy;


            Console.WriteLine(xx);
            Console.WriteLine(xy);
        }
    }
}
