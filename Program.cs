 using System;

namespace Discout
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Enter the payment:");
            sum = Convert.ToInt32(Console.ReadLine());

            if (sum >= 10 && sum < 20)
            {
                Console.WriteLine("You got 1 euro discount ticket");
            } 
            else if (sum >= 20 && sum < 50)
            {
                Console.WriteLine("You got 5 euro discount ticket");
            }
            else if (sum >= 50 && sum < 100)
            {
                Console.WriteLine("You got 10 euro discount ticket");
            }
            else if (sum >= 100)
            {
                Console.WriteLine("You got 15 euro discount ticket");
            }
        }
    }
}
