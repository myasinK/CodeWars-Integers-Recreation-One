using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kata_RecOne
{
    public class SumSquaredDivisors
    {
        public static string ListSquared(long m, long n)
        {
            int count = 1;
            var strFinal = "[";
            for (long i = m; i < n + 1; i++)
            {
                // find divisors 
                var listOfDivisors = SumSquaredDivisors.FindDivisors(i);
                // add square of divisors
                var divisorsSquaredAggregate = listOfDivisors.Aggregate(0, (long total, long next) => total + ( next * next ));
                // check if above is a perfect square
                var sqRoot = Math.Floor( Math.Floor( Math.Sqrt( divisorsSquaredAggregate ) ) );
                // if perfect square init 2 element array; place number and sum of squares in array
                //var isPerfectSquare = false;
                if (sqRoot * sqRoot == divisorsSquaredAggregate)
                {
                    //isPerfectSquare = true;
                    var str = String.Format("[{0}, {1}]",i,divisorsSquaredAggregate);
                    if ( count > 1 )
                    {
                        strFinal += ", " + str;
                    }
                    else
                    {
                        strFinal += str;
                    }
                    count++;
                }
            }

            strFinal += "]";
            return strFinal;
        }

        private static long[] FindDivisors(long number)
        {
            var listOfDivisors = new List<long>();
            if (number == 1)
            {
                listOfDivisors.Add(number);
                return listOfDivisors.ToArray();
            }
            else
            {
                for (long i = 1; i <= number/2; i++)
                {
                    if (number % i == 0)
                    {
                        listOfDivisors.Add(i);
                    }
                } 
                listOfDivisors.Add(number);
                return listOfDivisors.ToArray();
            }
        }
    }
}
