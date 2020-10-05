using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n >= n2 && n >= n3)
            {
                Console.WriteLine(n);
            }
            else if (n <= n2 && n >= n3)
            {
                Console.WriteLine(n2);
            }
            else if (n2 <= n && n2 <= n3)
            {
                Console.WriteLine(n3);
            }
            if (n >= n2 && n >= n3)
            {
                Console.WriteLine(n);
            }
            else if (n <= n2 && n >= n3)
            {
                Console.WriteLine(n2);
            }
            else if (n <= n2 && n <= n3)
            {
                Console.WriteLine(n3);
            }
            if (n >= n2 && n >= n3)
            {
                Console.WriteLine(n);
            }
            else if (n <= n2 && n >= n3)
            {
                Console.WriteLine(n2);
            }
            else if (n <= n2 && n <= n3)
            {
                Console.WriteLine(n3);
            }
        }
    }
}
