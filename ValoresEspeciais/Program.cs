using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {

            //Variables for all types max and min values
            sbyte sb = sbyte.MaxValue;
            sbyte sb2 = sbyte.MinValue;
            short sh = short.MaxValue;
            short sh2 = short.MinValue;
            int nt = int.MaxValue;
            int nt2 = int.MinValue;
            long lo = long.MaxValue;
            long lo2 = long.MinValue;
            byte by = byte.MaxValue;
            byte by2 = byte.MinValue;
            ushort us = ushort.MaxValue;
            ushort us2 = ushort.MinValue;
            uint ui = uint.MaxValue;
            uint ui2 = uint.MinValue;
            ulong ul = ulong.MaxValue;
            ulong ul2 = ulong.MinValue;
            char ch = char.MaxValue;
            char ch2 = char.MinValue;
            decimal de = decimal.MaxValue;
            decimal de2 = decimal.MinValue;

            //Printing the respective values
            Console.WriteLine(sb);
            Console.WriteLine(sb2);
            Console.WriteLine(sh);
            Console.WriteLine(sh2);
            Console.WriteLine(nt);
            Console.WriteLine(nt2);
            Console.WriteLine(lo);
            Console.WriteLine(lo2);
            Console.WriteLine(by);
            Console.WriteLine(by2);
            Console.WriteLine(us);
            Console.WriteLine(us2);
            Console.WriteLine(ui);
            Console.WriteLine(ui2);
            Console.WriteLine(ul);
            Console.WriteLine(ul2);
            Console.WriteLine(ch);
            Console.WriteLine(ch2);
            Console.WriteLine(de);
            Console.WriteLine(de2);

            //Variables for especial values
            double negative = double.NegativeInfinity;
            double positive = double.PositiveInfinity;
            float x = float.NaN;

            //Printing those variables
            Console.WriteLine(negative);
            Console.WriteLine(positive);
            Console.WriteLine(x);

        }
    }
}
