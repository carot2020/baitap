using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while(t>0)
            {
                string[] token = Console.ReadLine().Split(' ');
                int l = int.Parse(token[0]);
                int r = int.Parse(token[1]);
                Console.WriteLine(l + " " + 2*l );
                t--;


            }
            Console.ReadLine();
        }
    }
}
