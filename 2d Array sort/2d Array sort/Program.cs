using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Assignment 5 -  2 dimensional Array
How do you (declare and initialize and output ) a two-dimensional 
array in C#? Provide an example.
ass */

namespace _2d_Array_sort
{
    public class Assignment5
    {
        static void Main(string[] args)
        {
            // declare and initialization of  2D array
            int[,] array = {
            { 5, 3, 9, 1 },
            { 8, 7, 6, 2 },
            { 4, 10, 12, 11 }
        };


            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            // temporary 1D array to hold each row for sorting
            int[] tempRow = new int[cols];


            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    tempRow[j] = array[i, j];
                }

                Array.Sort(tempRow); // sorting

                // Copy the sorted row back to the 2D array
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = tempRow[j];
                }
            }




            Console.WriteLine("Sorted 2D array with row wise :");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
