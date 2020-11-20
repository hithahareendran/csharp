using System;
using System.Linq;

namespace Matrix
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Dimention (rows, column)");
            String[] dimensions = Console.ReadLine().Split(",");                   
            int rows = int.Parse(dimensions[0]);
            int columns = int.Parse(dimensions[1]);
            

            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Enter Matrix values");
            for (int i = 0; i < rows; i++)
            {
                String[] numberstring = Console.ReadLine().Split(",");
                for(int j=0; j<columns; j++)
                {
                    matrix[i, j] = int.Parse(numberstring[j]);
                }
            }

            int sum = 0;
            foreach( int number in matrix)
            {
                sum = sum + number;
            }
            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
