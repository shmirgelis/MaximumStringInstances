using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumStringInstances
{
    class MaximumStringInstances
    {
          static void Main(string[] args)
          {
              

                string randomString = "abcabcaabbncabbccc"; // random string
                string stringToFind = "abbccc"; // given string to find out how many times it appears in random string
                                    
                var letterCount = new Dictionary<char, int>(); //Dictionary to hold and count letters from stringToFind in randomString
                var stringToFindRepeatingLetters = new Dictionary<char, int>(); //Dictionary to hold repeating letters and count from stringToFind

                foreach (char c in stringToFind)
                {
                   int count = CountLettersInString(c, randomString); //checks to find if randomString contains letters from stringToFind and if contains counts the letters 
                
                   if (letterCount.ContainsKey(c))
                   {
                    FindsRepeatingLetters(c, stringToFindRepeatingLetters); // finds and count repeating letters in stringToFind
                   }
                   else
                   {
                       letterCount.Add(c, count);
                   }
                }
                
                foreach(var kvp in stringToFindRepeatingLetters)
                {
                if (letterCount.ContainsKey(kvp.Key))
                    {
                    letterCount[kvp.Key] = letterCount[kvp.Key] / stringToFindRepeatingLetters[kvp.Key];   //find repeated letter in letterCount and divide by how many times it is repeated, assign new value to key
                    }
                }

            int number = letterCount.Values.Min();
            Console.WriteLine($"Given string {stringToFind} appears {number} times");
          }

        private static void FindsRepeatingLetters(char c, Dictionary<char, int> stringToFindRepeatingLetters)
        {
            if (stringToFindRepeatingLetters.ContainsKey(c)) 
            {
                stringToFindRepeatingLetters[c] += 1;
            }
            else
            {
                stringToFindRepeatingLetters.Add(c, 2); //char c is already counted once, hence dictionary is created with value two
            }
        }

        private static int CountLettersInString(char ch, string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++) 
            {
                if (ch == str[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
