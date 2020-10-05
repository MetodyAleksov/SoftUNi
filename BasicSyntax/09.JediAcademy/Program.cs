using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.JediAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double robeTotal = studentCount * robePrice;
            double sabreTotal = lightsabrePrice * Math.Ceiling(studentCount * 1.10);
            double beltTotal = 0;
            for (int i = 1; i <= studentCount; i++)
            {
                if (i % 6 == 0)
                {

                }
                else
                {
                    beltTotal += beltPrice;
                }
            }
            double total = beltTotal + sabreTotal + robeTotal;
            if (budged >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(total - budged):f2}lv more.");
            }
        }
    }
}
