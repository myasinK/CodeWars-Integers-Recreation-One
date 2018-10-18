using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Full description of problem below
// https://www.codewars.com/kata/integers-recreation-one/train/csharp
// "brute force" method

namespace Kata_RecOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = SumSquaredDivisors.ListSquared(1,250);
            Console.WriteLine(x);
        }
    }
}
