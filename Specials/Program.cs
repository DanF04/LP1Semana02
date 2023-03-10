using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"sbyte min value: " + sbyte.MinValue);
            Console.WriteLine($"sbyte max value: " + sbyte.MaxValue);

            Console.WriteLine($"short min value: " + short.MinValue);
            Console.WriteLine($"short max value: " + short.MaxValue);

            Console.WriteLine($"int min value: " + int.MinValue);
            Console.WriteLine($"int max value: " + int.MaxValue);

            Console.WriteLine($"long min value: " + long.MinValue);
            Console.WriteLine($"long max value: " + long.MaxValue);

            Console.WriteLine($"byte min value: " + byte.MinValue);
            Console.WriteLine($"byte max value: " + byte.MaxValue);

            Console.WriteLine($"ushort min value: " + ushort.MinValue);
            Console.WriteLine($"ushort max value: " + ushort.MaxValue);

            Console.WriteLine($"uint min value: " + uint.MinValue);
            Console.WriteLine($"uint max value: " + uint.MaxValue);

            Console.WriteLine($"ulong min value: " + ulong.MinValue);
            Console.WriteLine($"ulong max value: " + ulong.MaxValue);

            Console.WriteLine($"float min value: " + float.MinValue);
            Console.WriteLine($"float max value: " + float.MaxValue);

            Console.WriteLine($"double min value: " + double.MinValue);
            Console.WriteLine($"double max value: " + double.MaxValue);

            Console.WriteLine($"decimal min value: " + decimal.MinValue);
            Console.WriteLine($"decimal max value: " + decimal.MaxValue);

            Console.WriteLine($"char min value: " + char.MinValue);
            Console.WriteLine($"char max value: " + char.MaxValue);


            double x = double.PositiveInfinity;
            double x2 = double.NegativeInfinity;
            double x3 = double.NaN;
            
            Console.WriteLine("special positive infinity: " + x);
            Console.WriteLine("special negative infinity: " + x2);
            Console.WriteLine("NAN x3: " + x3);

            int x4 = int.MaxValue;
            Console.WriteLine((int)(x4 + 1));



        }
    }
}
