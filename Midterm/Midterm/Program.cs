using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. The three types of control statements that we can use to order the statements in our programs are the sequence structure, the selection structure, and the iteration structure.
             The sequence structure refers to code executing line by line in the order that it is written. The selection structure refers to statements that alter the flow of control and
             are known as the if, if...else, and switch statements. An if statement performs an action if the statement is true and ignores it if it is false. An if...else statement performs
             a statement if it is true and another statement if it is false. The switch statement can perform multiple actions based on values that are provided. Lastly, the iteration structure
             refers to repetition or looping statements that are known as while, do...while, for and foreach. These statements can performs actions multiple times based on conditions that are
             provided. */

            //3 Create an infinite while loop. Use a Boolean variable called keepLooping that set to true in the loop’s termination condition.

            bool keepLooping = true;

            while (keepLooping)
            {
                Console.WriteLine("Looping is fun!");
            }

            /*4 Write a while loop to print 2 through 128 in brackets, each on a new line.  You should initialize your loop control variable to 2.  
                Output the value of the loop control variable each time through the loop.  Use a condition that ends the loop after 64 is printed. */

            int loopControlVariable = 2;

            while (loopControlVariable <= 128)
            {
                if (loopControlVariable <= 64)
                {
                    Console.WriteLine("{" + loopControlVariable + "}");

                    loopControlVariable = loopControlVariable * 2;
                }
            }

            /*5 Write a for loop that prints 49 through 1 separated by a comma.  Note, you will need to use a condition inside of the loops so it does not print the comma the 
              last time through (no newlines). */

            for (int j = 49; j >= 1; j--)
            {
                if (j > 1)
                {
                    Console.Write(j + ",");
                }
                else
                {
                    Console.Write(j);
                }
            }

            //6 Write a while loop that prints all odd numbers 1 through 21 separated by spaces (no newlines).

            int x = 1;
            while (x < 22)
            {
                if (x % 2 != 0)
                {
                    Console.Write(x + " ");
                }

                x++;
            }

            //7 What is the output for the following code?

            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition

            /*The output is a single *. A do-while statement executes its code at least once and since (i < n) evaluates to false, the loop would stop after the initial output. If a while
            statement was used, there would be no output at all since the loop would immediately evaluate to false. */

            //8 Explain how do we combine multiple Boolean values?  Write an if statement that outputs “Let’s go outside!” when both Boolean values are false.

            //We can combine multiple Boolean values into a single statement using the logical operators: &&(AND), ||(OR), and !(NOT).

            bool icyRain = false;
            bool tornadoWarning = false;

            if (!(icyRain && tornadoWarning))
            {
                Console.WriteLine("Let’s go outside!");
            }
        }
    }
}
