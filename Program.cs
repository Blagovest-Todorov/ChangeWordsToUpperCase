using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> selector = str => str.ToUpper();

            // create an array of strings
            string[] words = { "orange", "apple", "Article", "elephant" };
            //query the array and select strings according  to the selector method
            string[] bigLetterWords = words.Select(selector).ToArray();
            //output the results to  the console

            foreach (var word in bigLetterWords)
            {
                Console.WriteLine(word);
            }
        }        
    }
}
