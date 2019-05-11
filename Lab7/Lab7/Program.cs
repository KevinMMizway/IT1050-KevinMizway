using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class BookTest
    {
        static void Main(string[] args)
        {

            Book newBook = new Book("Meet me in the middle", "Kevin Mizway", 1985);
            newBook.Display();
        }

        public class Book
        {
            public string Title = "title";
            public string Author = "author";
            public int Year = 1990;

            public void Display()
            {
                Console.WriteLine(Title + " by " + Author);
            }

            public Book(string title, string author, int year)
            {
                Title = title;
                Author = author;
                Year = year;
            }

        }

        /*3 If we do not add a constructor method, the C# compiler will create an empty default constructor for us. By using a constructor method, we are able to initialize object values upon
         creation. */

        /*4 If we created two new constructor methods, we would be practicing the concept of polymorphism and method overloading. This is an example of code reuse and we would use different parameters
         for each method. */

        /*5 Exception Handling is important because it allows us to filter incorrect input from the user. With exception handling, our program can continue to run after an error and we can create
         reports or messages that let us know where the error occured. If we do not use exception handling, our program would crash and we will never know where the bug occured. */

        /*6 The purpose of private and public modifiers for our properties is for restricting the use of data in our programs. When a method or property uses a private modifier, it is not
         able to be accessed outside of the class. This would be used when we do not want certain properties to be changed in an unwanted way. As you can see, this is paramount for privacy and
         security. A public member is accessible by all classes. This is known as encapsulation or information hiding. */

        /*7
        Composition is a form of code reuse when a class contains references to other objects. We could use composition in our book class by incorporating an Author object in our Book class. This is
        a has-a relationship. "A book has an author." */

        /*8 Data Abstraction is the practice of hiding internal implementation details. Your goal is to only provide relevant information when needed. This reduces the complexity of a system
          immensely as everything that interacts with the system does not need to know how everything works. Abstract classes are used in C# to perform abstraction. */


    }
      
}
