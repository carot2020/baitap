using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] token = Console.ReadLine().Split(' ');
            
            if(token.Length == n)
            {
                int[] a = new int[n];
                for(int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(token[i]);
                }

                Array.Sort(a);

                int ans = Math.Min(Math.Min(a[n - 1] - a[0],a[n - 2] - a[0]),a[n - 1] - a[1]);
                Console.WriteLine(ans);
            }

            Console.ReadLine();

        }
    }
}
