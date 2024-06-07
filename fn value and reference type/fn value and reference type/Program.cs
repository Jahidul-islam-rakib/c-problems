using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment 4 - Value,Ref,Out

write a single program with function and elaborate with 2 different variable.

*/

namespace fn_value_and_reference_type
{
    public class fnDiffParatype
    {
        // for value type
        public void printSquareSum(int a, int b)
        {
            a *= a; // Manipulating value 
            b *= b;
            int sumWithinFn = a + b;

            Console.WriteLine("\nsquare sum value  inside the \"printSquareSum\" function " + sumWithinFn);

        }


        // for reference type
        public void sumOfSquare(ref int a, ref int b)
        {
            a *= a; // Manipulating value 
            b *= b;
            int sumWithinFn = a + b;

            Console.WriteLine("\nsquare sum value  inside the \"sumOfSquare\" function :" + sumWithinFn);

        }



        static void Main(string[] args)
        {
            int a = 5, b = 10;
            fnDiffParatype Sum = new fnDiffParatype();
            int sumBeforeFnCall = a + b;
            Console.WriteLine("sum value before calling the function :" + sumBeforeFnCall);

            Console.WriteLine("\n--------------call by value---------------");
            Sum.printSquareSum(a, b);
            sumBeforeFnCall = a + b; // if value of a and b are changed , then sumBeforeFnCall value will be updated
            Console.WriteLine("sum Value after calling the function using value type argument :" + sumBeforeFnCall + "\n\n");


            Console.WriteLine("\n--------------call by reference--------------- ");
            Sum.sumOfSquare(ref a, ref b); // Calling Function by passing reference            

            sumBeforeFnCall = a + b; // if value of a and b are changed , then sumBeforeFnCall value will be updated
            Console.WriteLine("sum Value after calling the function using reference type argument :" + sumBeforeFnCall);
        }
    }
}
