using System;
using System.Linq;
using System.Collections.Generic;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            var wordList = dictionary.ToList();
            

            for (int i = 0; i < dictionary.Length; i++)
            {
                var tempWordList = wordList;
                var tempJumble = jumble;

                //Remove from the list if the length isn't equal
                if (dictionary[i].Length != jumble.Length)
               {
                   tempWordList.Remove(dictionary[i]);
                   continue;
               }

               //remove from the list based on each word in the dictionary (determined by the characters in those words)
               foreach (var c in dictionary[i])
               {
                   var charToRemove = tempJumble.IndexOf(c);
                   {
                       if (!tempJumble.Contains(c))
                       {
                           tempWordList.Remove(dictionary[i]);
                           break;
                       }
                   }
                   tempJumble = tempJumble.Remove(charToRemove, 1);               
                   continue;
               }
            }
            return wordList.ToArray();
        }
    }
}