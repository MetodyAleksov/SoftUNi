using System;

namespace _05.Login
{ 
    
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length-1; i <= username.Length; i--)
            {
                password += username[i];
            }
            Console.WriteLine(password);
        }
    }
}
