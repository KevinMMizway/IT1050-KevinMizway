using System;


public class Lab2
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int product;

            Console.Write("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2;

            Console.WriteLine("Product is {0}", product);

            Console.WriteLine( "{0}\n{1}", "Hello World!", "From [Kevin Mizway]" );

            Console.WriteLine("Hello World!" + "    " + "From [Kevin Mizway]");

            //a. The point where our program executes is the Main method. This is the start and stop of our program.

            /*b. The difference between an integer type variable and a double/floating-point variable is based on the precision of the variable type.
             An int variable does not contain a decimal point whereas a floating-point variable does. A double type variable has even greater precision than a floating-type variable.
            */

            /*c. We can create blocks of code that we can call by name when using a method by creating a class that contains the class name, variable names, and methods that "get" and "set" the
             variable name. Let's use the example of creating a class with the name Account. In the example below the class Account is created with a variable name "name" with the type string.
             We can create methods such as SetName and GetName that call upon the class to retrieve and change the variable name. The example below shows the use of encapsulation to hide important fields
             from external classes.

            class Account
            {
                private string name;

                public void SetName(string accountName)
                {
                    name = accountName;
                }

                public string GetName()
                {
                    return name;
                }      
            }
            */

            /*d. To read the value of an instance variable, we create a method called a "get" accessor. To assign a value to an instance variable, we create a method called a "set" accessor. */

            /*e. A class is a blueprint or template for an object as objects are instances of their classes. This means that you only need to create a class once and as many copies(objects) as you want
              can be created from that class. We can theoretically have as many objects as we want until we exceed our memory capabilites as we are really just coping a class over and over. */
           
           

        }
    }
