using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 A one-dimensional array p contains four elements.  The array access expressions to access each of the elements in p are p[0], p[1], p[2] and p[3].

            //3
            string[] months = new string[12];

            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int month = 0; month < months.Length; month++)
            {
                Console.WriteLine($"{month} {months[month]}");
            }

            //4
            string[] seasons = {"Winter", "Spring", "Summer", "Fall"};

            foreach (var season in seasons)
            {
                Console.WriteLine($"{season}");
            }

            //5
            int[] integers = new int[1000];

            Random random = new Random();
            int randomNumber;

            for (int counter = 0; counter < integers.Length; counter++)
            {
                randomNumber = random.Next(0, 100);
                integers[counter] = randomNumber;
            }

            foreach (int integer in integers)
            {
                Console.WriteLine($"{integer}");
            }

            //6 and //7 I am a bit confused at what number 7 on the lab wants me to do. I have combined lab numbers 6 and 7 together here as it makes the most sense to me.
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i]);
                i++;
            }

            //8
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            
            

        }
    }
}
