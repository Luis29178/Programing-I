using System;
using System.Diagnostics.Contracts;
using Tester;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         * You cannot use multiple return statements any of these methods. 
         * Additionally the use of var is not permitted
         * 
        */

        // Test 1 – Convert char array to int array
        // Given an array of char, phrase, convert each element to an
        // equivalent int value and place in an int array.
        // Return the int array
        public static int[] Test1(char[] phrase)
        {

            int[] give = new int[phrase.GetLength(0)];
            for(int x =0; x < phrase.Length; x++)
            {
                give[x] = (int)phrase[x];
            }
            return give;
        }

        // Test 2 - Array statistics
        // Given an array of double, data, find the smallest element, 
        // the largest element and the numeric mean (average). Store the 
        // results in an array (in that order: smallest, largest, mean).
        // Return the array
        public static double[] Test2(double[] data)
        {
            double[] dta = new double[3];
           
            double small = data[0];
            double large = data[0];
            double sumall = 0;

            for(int x = 0; x < data.GetLength(0); x++)
            {

                if (small > data[x]) 
                {
                    small = data[x];
                }
                else if (large < data[x])
                {
                    large = data[x];
                }
                sumall += data[x];
                
            
            }
            double mean = sumall / data.GetLength(0);
            dta[0] = small;
            dta[1] = large;
            dta[2] = mean;
            return dta;
        }

        // Test 3 - Normalize an array (of double)
        // Given an array of double, numbers, normalize the array. To 
        // normalize an array:
        // 1) Find the largest element stored in the array
        // 2) Divide each element in the array by the largest value
        //    and replace each array element with the result of the 
        //    division.
        // Since the array's contents are being modified, there is 
        // nothing to return
        public static void Test3(double[] numbers)
        {
            double alpha = numbers[0];
            for(int x = 0; x < numbers.Length; x++)
            { 
                if(alpha < numbers[x])
                {
                    alpha = numbers[x];
                }
            }
            for(int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = (numbers[x] / alpha);
            }
           
        }

        // Test 4 - Uniqueness
        // Given an array of string, names, verify that each name is unique
        // mean that none of the names are duplicated within the array.
        // If the array is unique, return true; otherwise, return false
        //!!!!!!!!!!!use for loop!!!!!!!!!!!!!!!!!//
        public static bool Test4(string [] names)
        {
            bool ans = true;
            for(int x = 0; x < names.Length; x++)
            {
                for (int y = x + 1; y < names.Length; y++)
                {
                    if(names[x] == names[y])
                    {
                        ans = false;
                    }

                }
            }
            return ans;
            
        }

        // Test 5 - Acronym
        // Given an array of string, words, create a string that is the 
        // acronym (first letter of each word). Return the string
        public static string Test5(string [] words)
        {

            string ans = "";
            for(int x = 0; x < words.Length; x++)
            {
                string hold = words[x];
                        ans += hold[0];                

            }
            return ans;
        }

        // Test 6 - Array reverse
        // Given a char array, letters, create another array that has the
        // same elements but in reverse order. Return the array
        // 
        // You are not allowed to use Array.Reverse (or any existing
        // method) to reverse the array
        //
        public static char[] Test6(char[] letters)
        {
            char[] rev = new char[letters.Length];
            
            for(int y = (letters.Length - 1); y >= 0; y--)
            {
                for(int x = 0; x < letters.Length; x++)
                {

                    rev[x] = letters[y];
                    y--;

                }
            }

            return rev;
        }

        // Test 7 - Transpose array
        // Given a 2-Dimension array of int, table, create a new array that 
        // 'transposes' the original array. Transposing means that each row 
        // in the original array will be a column in the new array and each
        // column in the original array will be a row in the new array.
        // For example, given
        //   4   3   1   5
        //   2   7   0   8
        //
        // The transposed array would be
        //   4   2
        //   3   7
        //   1   0
        //   5   8
        //

        public static int[,] Test7(int [,] table)
        {
            int[,] tran = new int[table.GetLength(1), table.GetLength(0)];

            

            for (int x = 0; x < table.GetLength(0); x++)
            {
                for(int y = (table.GetLength(1) -1); y >=0; y--)
                {
                    tran[y, x] = table[x, y];
                }
            }
            return tran;
        }

        // Test 8 – Return a 2D array
        // Given three arrays of the same type (int) and size, combine the 
        // arrays into a single 2D array. Return the 2D array
        // NOTE: This solution requires a single loop (not three)
        // 
        public static int [,] Test8(int [] mins, int [] maxes, int [] seeds)
        {
            int[,] ans = new int[3, mins.Length];
            for(int x = 0; x < mins.Length; x++)
            {
                ans[0, x] = mins[x];
                ans[1, x] = maxes[x];
                ans[2, x] = seeds[x];
            }
            return ans;
        }

        // Test 9 – Convert int array to char array
        // Given an array of int, ascii, convert each element to an
        // equivalent char value and place in a char array.
        // Return the char array
        public static char[] Test9(int[] ascii)
        {
            char[] letters = new char[ascii.Length];
            for(int x=0 ; x < ascii.Length; x++)
            {
                letters[x] = (char)ascii[x];
            }

            return letters;
        }

        // Test 10 – Modify an existing array
        // Given an array of char (all uppercase), modify the array so
        // that every other element will be lowercase (even indexes are 
        // upper, odd indexes are lower)
        public static void Test10(char[] word)
        {
            for (int x = 1; x < word.Length; x = x + 2)
            {
                word[x] = Char.ToLower(word[x]);
            }
        }
    }
}
