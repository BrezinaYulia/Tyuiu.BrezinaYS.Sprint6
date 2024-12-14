using System.Numerics;

namespace eeeee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 94, 37, 28, 1 }, { 56, 12, -7, 8 }, { 8, 9, 5, 3 }, { 55, 33, 12, 70 }, { 96, 33, 27, 1 }, { 8, 51, 33, 6 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;
            int xCol = 4;
            for (int r = 0; r < rows; r++)
            {
                for (int c = xCol; c <= xCol; c++)
                {
                    if ((matrix[r, c] > 0) && (matrix[r, c] % 2 == 0))
                    {
                        matrix[r, c] = 111;
                    }
                }
            }
            //return matrix;

            Console.WriteLine(matrix);
        }
    }
}
