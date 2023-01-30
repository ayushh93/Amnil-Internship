using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Daytwo
    {
        /// <summary>
        /// Shuffle the Name
        /// </summary>
        /// <param name="name"></param>
        public void NameShuffle(string name)
        {
            string[] words = name.Split(' ');
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words)+"\n");
        }
        /// <summary>
        /// Smaller String Number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SmallerStringNumber(string a, string b) //this is not working
        {
            //Console.WriteLine($"First string is {a} and second string is {b} ";
            if (string.CompareOrdinal(a, b) < 0)
                Console.WriteLine($"The smaller string number is {a} \n");
            else if (string.CompareOrdinal(a,b) > 0)
                Console.WriteLine($"The smaller string number is {b} \n");
            else
                Console.WriteLine($"The smaller string number is {b}  \n");
        }
        /// <summary>
        /// Count hte number of potatoes in the given string
        /// </summary>
        /// <param name="str"></param>
        public void CountPotatoes(string str)
        {
            string[] words = str.Split("potato");
            Console.WriteLine($"The number of potato in the given string is {words.Length - 1} \n");
        }
        /// <summary>
        /// Swap the first and last character of a string
        /// </summary>
        /// <param name="str"></param>
        public void FirstLast(string str)
        {
            Console.WriteLine($"The first character of the string is {str[0]}. \n The second character of the string is {str[str.Length - 1]} \n");
        }
        /// <summary>
        /// Check if the given string is null
        /// </summary>
        /// <param name="str"></param>
        public void IsStringEmpty(string str)
        {
            Console.WriteLine($"[{str}] is "+string.IsNullOrEmpty(str)+ "\n");
        }
        /// <summary>
        /// Find the Bomb
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Bomb(string str)
        {
            return str.ToLower().Contains("bomb") ? "Duck!!! \n" : "There is no bomb, relax! \n";
            
        }
        /// <summary>
        /// Hackerspeak
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string HackersSpeak(string str)
        {
            return str.ToLower().Replace('a', '4').Replace('e', '3').Replace('i', '1').Replace('o', '0').Replace('s', '5');
        }
        /// <summary>
        /// Reverse Case
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverseCase(string str)
        {
            return string.Concat(str.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
        }
        /// <summary>
        /// Equality Check
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>returns true if the parameters are equal, and false if they are not.</returns>
        public bool CheckEquality(object a , object b)
        {
            return Object.Equals(a, b);
        }
        public void IndexOfCapitals(string str)
        {
            int[] arr = str.Select((x,i) => i ).Where(i => char.IsUpper(str[i])).ToArray();
            foreach(int arra in arr)
            {
                Console.Write($"{arra},");
            }
        }
    }
}
