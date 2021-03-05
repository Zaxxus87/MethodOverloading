using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,3));
            Console.WriteLine(Add(2.7, 9.3));
            Console.WriteLine(Add(2, 3, true));
            Console.WriteLine(Add(-2, 3, true));
            Console.WriteLine(Add(10, 3, false));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool addString)
        {
            var output = "";
            if (addString)
            {
                if (x + y == 1)
                    return $"1 dollar";
                else
                    return $"{x + y} dollars";
            }
            else
                return $"{x+y}";
        }
    }
}
