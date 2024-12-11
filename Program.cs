using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._3
{
    internal class Program
    {
        static int[,] CreateMatrix(int rows, int columns)
        {
            Random rnd = new Random();
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    matrix [i, j] = rnd.Next(0, 101);
                }
            }
            return matrix;
        }
        static void PrintMatrix(int[,] matrix) 
        {
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    Console.Write(matrix [i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }
        static (int, int, int) FindTheMaxValue(int[,] matrix) 
        {
            int max = matrix[0, 0];
            int rowmax = 0;
            int colummax = 0;

            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] > max) 
                    {
                        max = matrix[i, j];
                        rowmax = i;
                        colummax = j;
                    }
                }
            }
            return (max,rowmax,colummax);
        }
        static void Main(string[] args)
        {
            const int rows = 4;
            const int columns = 5;
            int[,] matrix = CreateMatrix(rows, columns);
            Random rnd = new Random();
         
            Console.WriteLine("Matrix:");
            PrintMatrix(matrix);
            (int max, int rowmax, int columnmax) = FindTheMaxValue(matrix);
            Console.WriteLine($"\n The maximun value is {max} at position ({rowmax + 1}, {columnmax + 1})");

            Console.ReadLine();
        }
    }
}
