using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. The if single-selection statement and the while repetition statement are similar to each other in that they both execute code based on if an expression is true.
                  The if statement is different than the while statement in that it changes the flow of control so that code that is not necessarily written directly next in the program
                  can be executed. The while statement executes a block of code repeatedly as long as the expression remains true. The while statement does not alter the flow of control
                  in a program.
            */

            //3
            int speedLimit;
            int speed;

            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            //4
            bool isTrue = true;

            if (isTrue)
            {
                Console.WriteLine("It is true!");
            }
            else
            {
                Console.WriteLine("It is false!");
            }

            //5
            Console.WriteLine("Please enter a temperature in fahrenheit and I will convert it to celcius.");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celcius = (fahrenheit - 32d) * 5d / 9d;

            if (fahrenheit < 40)
            {
                Console.WriteLine($"The celcius equivalent is: {celcius}. It is cold.");
            }
            if (fahrenheit > 90)
            {
                Console.WriteLine($"The celcius equivalent is: {celcius}. It is hot.");
            }

            //6
            int increaseValue = 1;
            
            while (increaseValue <= 10)
            {
                Console.WriteLine($"{increaseValue}");
                increaseValue += 1;
            }

            //7
            int decreaseValue = 60;

            while (decreaseValue >= 20)
            {
                Console.WriteLine($"{decreaseValue}");
                decreaseValue -= 5;
            }

            //8
            int increaseValueByTwo = 10;

            while (increaseValueByTwo <= 20)
            {
                Console.WriteLine($"{increaseValueByTwo}");
                increaseValueByTwo += 2;
            }
        }
    }
}
