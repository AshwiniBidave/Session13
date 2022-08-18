using System;

namespace MaxFloatCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("find the number");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            float c = Convert.ToSingle(Console.ReadLine());
            float output = MaxFloatCheck.findmaxnum(a, b, c);
            Console.WriteLine("Maximum Number is :" + output);
            if (output == a)
            {
                Console.WriteLine(+a + " is Maximum number place at Position 1");
            }
            if (output == b)
            {
                Console.WriteLine(+b + " is Maximum number place at Position 2");
            }
            if (output == c)
            {
                Console.WriteLine(+c + " is Maximum number place at Position 3");
            }

        }
    }
}
