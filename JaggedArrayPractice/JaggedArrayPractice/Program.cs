using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Assignment 7-jagged array

Write a C# program to create and initialize a jagged array of integers where the first row has
 3 elements, the second row has 2 elements, and the third row has 4 elements. Populate the array
 with sequential numbers starting from 1. Then, write a function to print the array in a structured
 forma
*/

namespace JaggedArrayPractice
{
    public class JaggedArray
    {
        public void getVal(int[][] Array)
        {
            Console.WriteLine("------------- Print the jagged array ------------- ");
            for (int row = 0; row < Array.Length; row++)
            {
                Console.Write("row no " + (row + 1) + ": ");

                for (int col = 0; col < Array[row].Length; col++)
                {
                    Console.Write(Array[row][col] + " ");
                }
                Console.Write("\n");
            }
        }


        public void setVal(ref int[][] array)
        {
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = cnt + 1;
                    cnt++;
                }
            }
        }

        public static void Main(string[] args)
        {
            int[][] arr = new int[3][];// Declare the array  

            arr[0] = new int[3];
            arr[1] = new int[2];
            arr[2] = new int[4];

            JaggedArray obj = new JaggedArray();

            obj.setVal(ref arr);
            obj.getVal(arr);




        }
    }
}
