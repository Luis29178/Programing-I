using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////chain your questions in an if statement
            //AskYesNoQuestion("Are you happy?");
            //AskYesNoQuestion("Are you blue?");
            //AskYesNoQuestion("Are you sitting down?");

            Random rand = new Random();
            for(int i = 0; i < 1000; i++)
            {
                AskYesNoQuestion("Random Question : " + rand.Next(222,9889));
            }

            //int number = 12;
            //number = Add5(number);
           
            ////number = number + 5;
            //Console.WriteLine(number);

            //int[] numbers = new int[6];

            ////print out all 0s
            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);

            //Set5(numbers);

            ////print out
            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);

            //functions
            //pass by value
            //pass by reference

            //prevent the app from closing without me telling it to close
            Console.ReadLine();
        }

        static int Add5(int value)
        {
           return value + 5;
        }

        static void Set5(int [] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 5;
            }
        }

        static public bool AskYesNoQuestion(string question)
        {
            while(true)
            {
                Console.WriteLine(question);
                string value = Console.ReadLine();

                //lower case the answer so we don't have to worry about capitalization
                if (value.ToLower() == "yes")
                {
                    return true;
                }
                else if (value.ToLower() == "no")
                {
                    return false;
                }
            }
        }
    }
}
