using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2
             The method getArea starts with the public keyword which grants this method access from anywhere else. This is opposed to the private keyword which means the method would only be able to be accessed by objects of its own class. This defines the scope of the method.

             Next in the header you have the double keyword which defines the return type of this method. The result of this method will use the return type, double.

             This method also does not include the keyword static which means it is a non-static method. Next comes the name(identifier) of the method, getArea. Typically, the standard naming convention for method names is PascalCase. This method uses two parameters with the type keyword double and the names as height and width. Because the parameters use the keyword double, they must accept arguments with the type double as well. Lastly, you have the method’s body which starts with the left brace and ends with the right brace. This method takes the arguments entered for its parameters and returns the result of height * width.
            */

            /* 3
              Methods that are provided with a framework are predefined along with classes and properties which are then built into libraries. These libraries are built so that the user does not have to ‘reinvent the wheel’ each time they create a solution. Some uses of these framework methods are to perform mathematical calculations, printing, database options, and error-checking. This known as software reuse.

              User-defined methods are custom methods created by the user. The user should create a method to perform a specific action that is not already defined in a method provided by the framework. The user should indicate the scope of the method, return type, name, parameters, and body.
            */

            /* 4
             
             Static methods are methods that can be called without first creating an object of the method’s class.  A static method belongs to its class and a non-static method belongs to the object of the class. A static method also only has access to static variables as they both belong only to the class. In order to use a non-static method, an object of the class must first be created.
            */

            // 5 Add bark() method
            public void Bark()
            {
                Console.WriteLine("{0} is Barking...", Name);
            }

            // 6 Add doTrick() method
            public void DoTrick(string trickName)
            {
                Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", Name, trickName);
            }

        }
    }
}
