using System;

namespace _1
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int x = Convert.ToInt32(number);
            Double res1 = tavan2(x);
            Double res2 = tavan3(x);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }//end main
        private static double tavan2(int x)
        {
            double a = Math.Pow(x, 2);
            return a;
        }//end
        private static double tavan3(int x)
        {
            double b = Math.Pow(x, 3);
            return b;
        }//end
        
    }//end class
}
