using System;

namespace Ovning1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            double cel;
            double far;
           
            Console.WriteLine("Mata in grader i Celsius: ");

            userInput = Console.ReadLine();

            cel = Convert.ToDouble(userInput);

            far = (cel * 1.8) + 32;

            Console.WriteLine("Det blir " + far + " grader Farenheit");



            Console.ReadLine();
        }
    }
}
