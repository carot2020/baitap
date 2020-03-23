using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');
            int n = int.Parse(token[0]);
            int m = int.Parse(token[1]);
            int a = int.Parse(token[2]);

            if(m % a == 0 && n % a == 0)
            {
                Console.WriteLine((m/a) * (n/a));
            }
            if (m % a > 0 && n % a == 0)
            {
                Console.WriteLine((m/a + 1) * (n/a));
            }
            if (m % a == 0 && n % a > 0)
            {
                Console.WriteLine((m/a) * (n/a + 1));
            }
            if (m % a > 0 && n % a >  0)
            {
                Console.WriteLine((m/a + 1) * (n/a + 1));
            }
            Console.ReadLine();
        }
    }
}
