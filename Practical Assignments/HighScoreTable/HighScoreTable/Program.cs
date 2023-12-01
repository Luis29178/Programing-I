/////////////////////////////////////////////////////////////////////////////
// TODO:    BEFORE YOU WRITE ANY CODE: 
//          1) Read the Instructions.pdf file.
//          2) Run the example.exe to see how this program will behave.
//          3) Read through all of the TODOs. This will give you an overview
//          of how the program will be put together.
//
//          Unless where specified, the program does not have to look exactly
//          like the example (e.g. text doesn't have to be centered on screen)
/////////////////////////////////////////////////////////////////////////////
using System;
using FSPG;


namespace HighScoreTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Ask the user how many high scores they want.
            //       Then read in their input.           
            //       Support error checking (input validation).
            //       The user should only be able to input a positive
            //       integer value.
            //       You may use Utility.ReadInt() and Utility.IsReadGood()
            //       to help you with error checking.


            // TODO: Define an array of ints, which will hold the high scores.
            //       Make the array the exact size indicated by the user above.
            
            
            // TODO: Ask the user for each high score, and read in their inputs.
            //       Make sure to read in as many high scores are in the array.
            //       If the high score array is size 5, then read in 5 inputs.
            //       You DO NOT NEED to support error checking for each score;
            //       assume each input will be an integer.
            
            Console.WriteLine("How many highschors would you like?");          
            int HS = Utility.ReadInt();
             bool acc = Utility.IsReadGood();

                while (!acc || HS < 0)
                {
                        Console.Clear();
                        Console.WriteLine("Invalid input pleas provide positive int.");
                        HS = Utility.ReadInt();
                        acc = Utility.IsReadGood();
                        Console.Clear();
                }

            
                int[] HighScores = new int[HS];

            for (int i = 0; i <= HS - 1; i++)
            {
        
                Console.WriteLine("HighScore " + (i + 1));
                int hs = int.Parse(Console.ReadLine());
                HighScores[i] += hs;
            }
            // TODO: Uncomment the following lines
            Console.WriteLine();
            Console.WriteLine("High Scores - Unsorted");

            // TODO: Call your PrintArray function passing the array of high scores.
            
            PrintArray(HighScores);

            // TODO: Call the SortArrayHighToLow procedure,
            //   passing the array of high scores, to sort them.

            SortArrayHighToLow(HighScores);

            // TODO: Uncomment the following lines
            Console.WriteLine();
            Console.WriteLine("High Scores - Sorted");

            // TODO: Call your PrintArray function passing the array of high scores.
            PrintArray(HighScores);

            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }

        // TODO: Write a function called PrintArray that takes as input
        //       a single int array, and returns nothing.
        //       The function will loop through the array and print out
        //       each int on its own line.
        //       Don't forget the keyword static.


        /// <summary>
        /// This procedure takes an array of ints and sorts them in place.
        /// After a call to this procedure the array of ints passed in will be
        /// sorted from highest to lowest.
        /// </summary>
        /// <param name="numbers">an array of ints to sort</param>
       
         static void PrintArray(int[] X)
            {
              for(int i = 0;i < X.Length;i++)
                {
                    Console.WriteLine(X[i]);
                }
            }
        static void SortArrayHighToLow(int[] numbers)
        {
            int tmp;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i; j > 0 && numbers[j] > numbers[j-1]; j--)
                {
                    tmp = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = tmp;
                }
            }
        }

    }
}
