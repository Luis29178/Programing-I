using System;

namespace ConsoleApp1
{
    class Program
    {          
                        

         public static void Main(string[] args)
        {
            Random num = new Random();
            int number = num.Next(0, 100);            
            double Tnum = 0;
            int i = 0;
            int gcount = 0;
            int avr = 0;
            int rounds = 0;
            int[] avarage = new int[rounds];
            bool retry = true;

            Console.WriteLine("Want to play?\n Press any key to continue...");
            Console.ReadKey();
            while (retry)
            {

                while (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Guess a number between 1 and 100");
                    Tnum = number;
                    i++;
                }


                while (i == 1)
                {

                    Console.WriteLine("********Gess 101 to quit.**********");
                    Console.WriteLine("********Gess 102 to restart.**********");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    string g = Console.ReadLine();
                    int gess = int.Parse(g);

                    if (gess == 101)
                    {
                        break;
 
                    }
                    if (gess == 102)
                    {
                        Console.Clear();
                        retry = false;
                        gcount = 0;
                        avr = 0;
                    }
                    else if (gess == Tnum)
                    {
                        Console.Clear();
                        Console.WriteLine("Nice you got it");
                        rounds++;
                        gcount++;
                        
                        Console.WriteLine("Trys: " + gcount);
                    }
                    else if (gess < Tnum && gess > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("To Low.");
                        gcount++;
                        rounds++;
                        Console.WriteLine("Trys: " + gcount);
                    }
                    else if (gess > Tnum && gess < 101)
                    {
                        Console.Clear();
                        Console.WriteLine("To High.");
                        gcount++;
                        rounds++;

                        Console.WriteLine("Trys: " + gcount);
                    }
                    else if (gess < 0 || gess > 100)
                    {
                        Console.WriteLine("1- 100 turd");
                        Console.WriteLine("Trys: " + gcount);


                    }



                }
                
            }
            rounds++;
            retry = true;

        }
    }
}
