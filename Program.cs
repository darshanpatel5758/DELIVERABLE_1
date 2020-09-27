using System;
using System.ComponentModel;

namespace Deliverable1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            string s = "!";
            int count = 0;
            int count1 = 0;


            for (int i = 0; i < password.Length; i++)
            {
            
                if (char.IsUpper(password[i])) count++;
                if (char.IsLower(password[i])) count1++;
                
            }

            if (password.Contains(s))
            {
                if (password.Length < 7 || password.Length > 12 || count < 1 || count1 < 1)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    Console.WriteLine("Password valid and accepted");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }


        }
    }
}
