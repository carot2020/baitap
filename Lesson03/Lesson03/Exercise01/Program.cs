using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int grade = int.Parse(Console.ReadLine());
            int gradeTotal = 0;
            while (grade != -1)
            {
                gradeTotal += grade;
                total++;
                grade = int.Parse(Console.ReadLine());
            }
            double gpa = gradeTotal / total;
            Console.WriteLine(gpa.ToString("0.00"));
        }
    }
}
