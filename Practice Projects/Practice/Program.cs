using System;

using FSPG;


/////////////////////////////////////////////////////////////////////////////
// TODO: {X}BEFORE YOU WRITE ANY CODE: 
//          Read the Instructions.pdf file.
//          Run the example.exe to see how this program will behave.
//          Read through all of the TODOs. This will give you an overview
//          of how the program will be put together.

namespace Practice
{
    class Program
    {
        static string[] Greetings = { "Hello there!", "Welcome to the practice!", "Hi, user!", "Hey, I am a program.", "You're running the best program ever!" };

        static void Main(string[] args)
        { // TODO: {X}Display a random string from the Greetings array.


            {
                Random X = new Random();
                int inex = X.Next(Greetings.Length);
                Console.WriteLine($"{Greetings[inex]}");
                Console.WriteLine("\n\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
                //TODO:
                //       {X}Ask the user for a positive number and then print the square of that number.
                //       {X}Make sure your progarm does not crash if the user enters bad input.
                //       {X}Make sure the user can keep entering input until they enter good input
                Console.WriteLine("Tell me a positive number. I can square it!");
            Start:
                string a = Console.ReadLine();
                int A;
                if (int.TryParse(a, out A) && A >= 0)
                {
                    double sqRoot = Math.Round(Math.Sqrt(A), 4);
                    Console.WriteLine("The Square root of " + A + " is " + sqRoot);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Tell me a positive number. I can square it!");
                    goto Start;
                }

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////                


                // TODO: {x}Create an array of doubles. Use a random number (in the range of 3 to 6) for the size.
                //       {X}For each element of the array, ask the user to enter a value and store
                //       {X}it in the array. The input does not have to be error checked.





                Console.WriteLine("Pick 4 random numbers");
                Console.WriteLine("\n\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Pick 4 random numbers");

                double[] dbls = new double[4];
                for (int z = 0; z < dbls.Length; z++)
                {
                    dbls[z] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Pick 4 random numbers");
                }
                Console.Clear();
                Console.WriteLine("These are your numbers.");
                for (int z = 0; z < dbls.Length; z++)
                {
                    Console.Write(dbls[z] + ", ");
                }
                Console.WriteLine("\n\n\npress any key yo continue...");
                Console.ReadKey();


                // TODO: Call the FindAverage method passing in the array of doubles and display
                //       the return value to the screen.
                double[] FindAverage = { 32, 78, 56.236, .375 };
                //double dividen = FindAverage.Length();

                for (int i = 0; i < FindAverage.Length; i++);
                {
                  //  Console.Write(FindAverage[i] + ", ");
                }
               // Console.WriteLine(Display);



            }



                // TODO: In the FindAverage method compute the average (the sum of all values divided by the number of values)
                //       of the values in the array parameter and return it.









            }





            }
        }
    
    

