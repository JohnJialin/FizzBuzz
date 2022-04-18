using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, John!");

            //string[] aaa = {"1", "john", "", "3", "4", "5", "15"};

            Helper helper = new Helper();

            //Convert string array to number array
            int[] numberArray = helper.ConvertStringToIntArray(args);

            //main solution method here
            List<string> resultList = helper.FizzBuzzValues(numberArray);

            //print out result
            resultList.ForEach(i => Console.Write("{0}\t", i));
        }

    }
}
