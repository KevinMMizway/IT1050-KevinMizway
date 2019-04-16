using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                2. The four basic elements of counter-controlled reptition are the counter variable, the initial value of the control variable,
                the loop-continuation condition, and the increment/decrement expression. The counter variable and its initial value describe the
                starting place of the loop. This is also known as the loop counter. Next, the loop-continuation condition checks if the expression
                evaluates to true and continues the looping. The control variable's increment/decrement expression changes the value of the control variable
                after each loop.

                3. The while and for loop statements are both similiar iteration statements in that they both check if a condition is true before executing a piece of code.
                   The for loop includes counter and increment statements in its header which organizes its loop elements in one place. This is why the for loop
                   is typically preferred for loops where the number of iterations are known beforehand. A while loop is typically preferred when conditions are not known
                   in advance and a sentinel value is used to stop the loop.
                
                4. A do-while statement would be more appropiate to use than a while statement when you want to make sure that a block of code is executed at least once instead
                of not at all. An example where this could be useful is when asking for input from a user in the console. This ensures that the user will at least be asked for input
                and then the condition statement can choose when the loop will stop after receiving the input.
            */

                //5

                for (int i = 1; i <= 100; i++)
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine($"{i} is even");
                    }
                    else {
                        Console.WriteLine($"{i} is odd");
                    }
                }

                //6
                Console.WriteLine("Please enter a temperature.");
                string input = Console.ReadLine();

                int temp = int.Parse(input);
                
                if (temp < 10)
                {
                    Console.WriteLine("Polar Bear");
                } else if (temp < 20)
                {
                    Console.WriteLine("Penguin");
                } else if (temp < 40)
                {
                    Console.WriteLine("Moose");
                } else if (temp < 50)
                {
                    Console.WriteLine("Reindeer");
                } else if (temp < 60)
                {
                    Console.WriteLine("Deer");
                } else if (temp < 70)
                {
                    Console.WriteLine("Turtle");
                } else if (temp < 80)
                {
                    Console.WriteLine("Lion");
                } else if (temp < 90)
                {
                    Console.WriteLine("Fish");
                } else 
                {
                    Console.WriteLine("Bug");
                }

                //7 - The problem with the example is the while loop does not contain an increment expression.
                int i = 10;
                while (i < 21)
                {
                    Console.WriteLine(i);
                }


                //The correct code should be as follows:
                int i = 10;
                while (i < 21)
                {
                    Console.WriteLine(i);
                    i++;
                }

                //8 The following statement is wrong because it does not include brackets for the body of the loop. This means Console.WriteLine(i) is the only statement that is looped.
                for (int i = 0; i < 101; i++)
                    Console.WriteLine(i);
                    Console.WriteLine("********");

                //The correct statement should be as follows:
                for (int i = 0; i < 101; i++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("********");
                }

        }
    }
}
