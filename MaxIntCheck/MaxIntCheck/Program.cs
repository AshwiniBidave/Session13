using System;

namespace MaxIntCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("find the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int output = MaxIntCheck.findmaxnum(a, b, c);
            //Console.WriteLine("Maximum Number is :" + output);
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
