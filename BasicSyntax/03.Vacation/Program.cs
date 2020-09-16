using System;

namespace Textadventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalPrice = 0;

            if (type == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = numOfPeople * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = numOfPeople * 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = numOfPeople * 10.46;
                }
                if (numOfPeople >= 30)
                {
                    totalPrice = totalPrice * 0.85;
                }
            }
            else if (type == "Business")
            {
                if (numOfPeople >= 100)
                {
                    numOfPeople -= 10;
                }
                if (dayOfWeek == "Friday")
                {
                    totalPrice = numOfPeople * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = numOfPeople * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = numOfPeople * 16;
                }
            }
            else if (type == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = numOfPeople * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = numOfPeople * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = numOfPeople * 22.50;
                }
                if (numOfPeople >= 10 && numOfPeople <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
