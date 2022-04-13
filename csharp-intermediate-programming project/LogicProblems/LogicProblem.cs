using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicProblems
{
    public class LogicProblem : ILogicProblem
    {
        /// <summary>
        /// This function should take an array of ints and return the average of all values as a double
        /// with precision to two decimal places. Negative ints will throw an argument exception.
        /// </summary>
        /// <param name="scores"></param>
        /// <returns>average of values with 2 decimal places</returns>
        /// <exception cref="NotImplementedException"></exception>
        public double Average(int[] scores)
        {
            if (scores.Length == 0) //if scores array is empty, return 0.00.
            {
                return 0.00;
            }

            for (int i = 0; i < scores.Length; i++) //while looping through scores,
            {
                if (scores[i] < 0) //if any int is less than zero (a negative number),
                {
                    throw new ArgumentException("scores must be positive"); //throw argument exception.
                }
            }

            return Math.Round(scores.Average(), 2, MidpointRounding.AwayFromZero); //return the average of scores with a decimal precision of 2.
        }

        /// <summary>
        /// Given a positive integer, this function should return the number of distinct paths to reach the top
        /// of the ladder. Negative ints will throw argument exception. 
        /// </summary>
        /// <param name="rungs"></param>
        /// <returns>number of distinct paths</returns>
        /// <exception cref="NotImplementedException"></exception>
        public decimal DistinctLadderPaths(int rungs)
        {
            decimal current = 1, last = 1; //creates double variable.

            if (rungs < 0) //if rungs are less than zero (a negative number),
                {
                    throw new ArgumentException("ladders can't have negative rungs"); //throw argument exception.
                }
                if (rungs < 3)
                {
                    return rungs;
                }

            for (int i = 1; i < rungs; i++) //while looping through,
            {
                decimal temporary = current; //creates variable to temporarily store data
                current = current + last; //do more research on fibonacci
                last = temporary;
            }
            return Math.Round((decimal)current);
        }

        /// <summary>
        /// Given an array of strings, when this function is called, a List of Lists is
        /// returned containing properly grouped strings. Strings within a grouping must share
        /// the same first and last letters. 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns>list of grouped strings</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<List<string>> GroupStrings(string[] strs)
        {
            var map = new Dictionary<string, List<string>>(); //creates new Dictionary variable to contain string list.
            foreach (var str in strs) //for each string in string array strs,
            {
                if (string.IsNullOrWhiteSpace(str)) //if the string is empty,
                {
                    throw new ArgumentException("strings must not be empty"); //throw argument.
                }

                var key = str.Substring(0, 1) + str.Substring(str.Length - 1, 1); //creates key variable with value pairs using substring parameters of first and last letters.
                List<string> firstLastLetters; //creates new list

                if (map.TryGetValue(key, out firstLastLetters)) //if, when accessing map values, string key parameters match (first and last letters),
                {
                    firstLastLetters.Add(str); //add that string to the new list
                }
                else
                {
                    map.Add(key, new List<string>() { str }); //otherwise, add strings to the new dictionary.
                }
            }

            var result = map.Values.ToList(); //creates result variable that converts dictionary values to a list.
            return result;
        }

        /// <summary>
        /// Given a string, when this function is called, the length of the last word in the string is returned.
        /// An empty string will throw an exception. 
        /// </summary>
        /// <param name="text"></param>
        /// <returns>length of last word</returns>
        /// <exception cref="NotImplementedException"></exception>
        public int LastWordLength(string text)
        {
            if (String.IsNullOrEmpty(text)) //if string text is null or empty,
                {
                    throw new ArgumentException("input must not be an empty string"); //throw argument exception.
                }

            return text.Trim().Split(' ').Last().Length; //returns the length of last word in param text trimmed of any empty/white space at beginning and end.
        }
    }
}
