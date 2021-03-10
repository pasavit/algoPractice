using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            workSpace workSpace = new workSpace();

            //workSpace.FizzBuzz();
            //Console.ReadLine();

            //var output = workSpace.ReverseAString("trial");
            //Console.WriteLine(output);
            //Console.ReadLine();

            //var output = workSpace.CapFirstLetter("trial of cap");
            //Console.WriteLine(output);
            //Console.ReadLine();

            //var output = workSpace.CompressString("aaabbcdddd");
            //Console.WriteLine(output);
            //Console.ReadLine();

            workSpace.PalindromeCheck("cat");
            Console.ReadLine();
        }
    }
}
