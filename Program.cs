using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                int[][] matrix = new int[3][];
                matrix[0] = new int[] { 1, 2, 3, 4 };
                matrix[1] = new int[] { 5, 6,0 };
                matrix[2] = new int[] { 7, 8, 10 };
                //Access and store the value of the second element in the first row
                int element = matrix[0][1];

                Console.WriteLine("Display the matrix");
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        Console.Write(matrix[i][j] + " ");
                    }
                    Console.WriteLine();
                }

                // Modify the third element in the second row of the matrix to have a value of 15
                matrix[1][2] = 15;
            
            Console.WriteLine("After modifying the matrix");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            
            object[][] objectMatrix = new object[2][];
                objectMatrix[0] = new object[] { 42, "Hello", 3.14 };
                objectMatrix[1] = new object[] { true, 'A', DateTime.Now };

                Console.WriteLine("\n Display the object Matrix");
                for (int i = 0; i < objectMatrix.Length; i++)
                {
                    for (int j = 0; j < objectMatrix[i].Length; j++)
                    {
                        Console.WriteLine($"Type: {objectMatrix[i][j].GetType()},\t Value: {objectMatrix[i][j]}");
                    }
                    Console.ReadKey();
                }
            }
        }

    }
