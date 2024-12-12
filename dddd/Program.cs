namespace dddd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { -7, 34, -2, 25, 5 }, { -16, -12, 30, -3, 17 }, { 3, -15, 12, 5, -5 }, { 17, 22, -3, 32, -11 }, { 9, 28, 1, -9, -2 } };

            int[] ch = new int[5];
            int rows = matrix.GetUpperBound(0) + 1; //количество строки
            int columns = matrix.Length / rows;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i == 1)
                    {
                        ch[i] = matrix[j, i];
                    }
                }
            }
            Array.Sort(ch);
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i == 1)
                    {
                        matrix[j, i] = ch[i];
                    }
                }
            }
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }
        }
    }
}
