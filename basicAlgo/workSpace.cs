using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicAlgo
{
    public class workSpace
    {
        public void FizzBuzz()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public string ReverseAString(string input)
        {
            var output = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }

        public string CapFirstLetter(string input)
        {
            var output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if(i == 0 || input[i-1] == ' ')
                {
                    output += input[i].ToString().ToUpper();
                }
                else
                {
                    output += input[i].ToString();
                }
            }
            return output;
        }

        public string CompressString(string input)
        {
            var output = "";
            var count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if(i == input.Length - 1)
                {
                    output += count;
                    output += input[i];
                }
                else if(input[i] == input[i + 1])
                {
                    count++;
                }
                else
                {
                    output += count;
                    output += input[i];
                    count = 1;
                }
            }
            return output;
        }

        public void PalindromeCheck(string input)
        {
            var reversed = ReverseAString(input);
            if(input == reversed)
            {
                Console.WriteLine("Is a palindrome");
            }
            else
            {
                Console.WriteLine("Is NOT a palindrome");
            }
        }

        public bool PalindromeByComp(string input)
        {
            var isPalindrome = true;
            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[input.Length - 1-i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}
