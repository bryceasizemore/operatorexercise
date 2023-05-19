using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //For divison, create two integer variables

            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder =a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("please enter the radius of your circle:");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);

            AreaOfCircle(radius);
            AreaOfCircle(15);
        }

        //define a method - which performs some functionality. that can be used over and over again
        public static double AreaOfCircle(double radius) 
        { 
            var area = Math.PI * Math.Pow(radius, 2);
            
            return area; 
        }
    }
}
