using System;

namespace Exercise03
{
    class Program
    {
        /*
         * Flag = False: So do la so nguyen to
         * Flag = True: So do ko la so nguyen to
         */

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool flag = false;

            if(n == 1 || n == 0)
            {
                Console.WriteLine("No");
            }    

            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                    flag = true; 
                i++;
            }

            if (flag) Console.WriteLine("No");
            else Console.WriteLine("Yes");
        }
    }
}
