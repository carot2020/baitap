using System;

/**
 * Input
 *      Dòng đầu tiên chứa hai số nguyên n và k (1 ≤k≤n≤50) cách nhau bởi một khoảng trắng.
 *      Dòng thứ hai chứa n số nguyên được phân tách bằng dấu cách a_1,a_2,...,a_n  (0≤a_i≤ 100), trong đó a_i là số điểm mà người tham gia ở vị trí thứ i giành được. Trình tự đã cho là không tăng (nghĩa là với i từ 1 đến n-1, điều kiện sau được thỏa mãn: a_i≥a_(i+1)).
 * Output
 *      Xuất số lượng người tham gia tiến vào vòng tiếp theo.
 *      
 * Input                Output
 * 8 5                  4 2
 * 10 9 8 7 7 7 5 5     0 0 0 0
 */

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            string[] token = Console.ReadLine().Split(' ');
            n = int.Parse(token[0]);
            k = int.Parse(token[1]);
            string[] mark = Console.ReadLine().Split(' ');
            if (mark.Length == n)
            {
                int a = int.Parse(mark[k + 1]);
                if (a > 0)
                {
                    Console.WriteLine(k + 1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
            else
            {
                Console.WriteLine("Data Error");
            }
            Console.ReadLine();
        }
    }
}
