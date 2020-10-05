using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Раге
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLostGames = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalExpenses = 0;

            int headsetCounter = 0;
            int mouseCounter = 0;
            int keyboardCounter = 0;

            for (int i = 1; i <= numberOfLostGames; i++)
            {
                headsetCounter++;
                mouseCounter++;
                if (headsetCounter >= 2 && mouseCounter >= 3)
                {
                    keyboardCounter++;
                    totalExpenses += keyboardPrice;
                }
                if(headsetCounter >= 2)
                {
                    totalExpenses += headSetPrice;
                    headsetCounter = 0;
                }
                if(mouseCounter >= 3)
                {
                    totalExpenses += mousePrice;
                    mouseCounter = 0;
                }
                if (keyboardCounter >= 2)
                {
                    totalExpenses += displayPrice;
                    keyboardCounter = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
