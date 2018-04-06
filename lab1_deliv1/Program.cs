using System;
using System.Linq;

using System.Collections.Generic;

namespace lab1_deliv1
{
    class MainClass
    {
        // separate method for the comparison task
        static void ComparisonMethod(List<int> alist)
        {
            var allAreSame = alist.All(x => x == alist.First());
            Console.WriteLine("");
            Console.WriteLine(allAreSame);
        }

        static void Main(string[] args)
        {
        Start:
            //instructions delivered to user

            Console.WriteLine("Enter two whole numbers with the same number of digits to determine if each corresponding place in the two whole numbers (ones, tens, hundreds, ...) sums to the same total.");
            Console.WriteLine("Note: Valid number choices must be whole numbers.");

            // user enters the first number, ints are separated into a list

            Console.WriteLine("\nEnter the first whole number:");
            var choiceone = Console.ReadLine();
            int Num;
            bool isNum = int.TryParse(choiceone.ToString(), out Num);
            if (isNum != true)
            {
                Console.Write("Not a valid number\n\n");
                goto Start;
            }
            else { }
            List<int> numone = choiceone.Select(c => int.Parse(c.ToString())).ToList();


            // user enters the second number, ints are separated into a list

            Console.WriteLine("\nEnter the second whole number:");
            var choicetwo = Console.ReadLine();
            int Numtwo;
            bool isNumtwo = int.TryParse(choicetwo.ToString(), out Numtwo);
            if (isNumtwo != true)
            {
                Console.Write("Not a valid number\n\n");
                goto Start;
            }
            else
            { }
            List<int> numtwo = choiceone.Select(c => int.Parse(c.ToString())).ToList();

            // check to see if choice lengths are the same, if not return to start
            if (choiceone.Length != choicetwo.Length)
            {
                Console.WriteLine("\nThe length of the numbers you entered are not the same, try again\n");
                goto Start;
            }
            else
            { }

            // create the third list, made of the sums of both lists
            var sumList = choiceone.Zip(choicetwo, (x, y) => x + y).ToList();
            // sumList.ForEach(i => Console.Write("{0}\t", i));

            // check if all of the sums in the third list are the same
            {
            }
            ComparisonMethod(sumList);
            Console.WriteLine("\nPress any key to close.");
            Console.ReadKey();
        }

    }
}



