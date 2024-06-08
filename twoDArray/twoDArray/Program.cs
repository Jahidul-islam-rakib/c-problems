using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Assignment 6-2d

Write a C# program to create and initialize a 2-dimensional array of integers representing a 
3x3 matrix. Populate the array with sequential numbers starting from 1. Then, write a function 
to print the array in a structured format.

*/

namespace twoDArray
{
    public class _2dArray
    {
        public void setVal(ref int[,] arr)
        {
            int cnt = 0;
            for (int row = 1; row <= 3; row++)
            {
                for (int col = 1; col <= 3; col++)
                {
                    arr[row - 1, col - 1] = cnt + 1;
                    cnt++;
                }
            }

        }

        public void getVal(int[,] Array)
        {
            Console.WriteLine("------------- Print the 2d array ------------- ");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(Array[row, col] + " ");
                }
                Console.Write("\n");
            }
        }


        public static void Main(string[] args)
        {
            int[,] array2d = new int[3, 3];

            _2dArray obj = new _2dArray();
            obj.setVal(ref array2d);
            obj.getVal(array2d);


        }
    }
}
