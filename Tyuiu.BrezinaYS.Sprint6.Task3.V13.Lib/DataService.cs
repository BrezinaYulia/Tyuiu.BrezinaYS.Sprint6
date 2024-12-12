using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrezinaYS.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            //int rows = matrix.GetUpperBound(0) + 1; //количество строки
            //int columns = matrix.Length / rows;     //количество столбцы
            //List<int> numbers = new List<int>(rows);
            //for (int i = 0; i < rows; i++)
            //{

            //    numbers.Add(matrix[i, 1]);

            //}
            //numbers.Sort();
            //for (int j = 0; j < rows; i++)
            //{
            //    for (int i = 0; i < columns; j++)
            //    {
            //        for (int r = 0; r < 5; r++)
            //            if (j == 1)
            //            {
            //                matrix[i, j] = numbers[r];
            //            }

            //    }
            //}
            //return matrix;

            int[] ch = new int[5];
            int rows = matrix.GetUpperBound(0) + 1; //количество строки
            int columns = matrix.Length / rows;  
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i == 1)
                    {
                        ch[i]=matrix[j, i];
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
                        matrix[j,i] = ch[i];
                    }
                }
            }
            int[,] wait = { { -7, -15, -2, 25, 5 }, { -16, -12, 30, -3, 17 }, { 3, 22, 12, 5, -5 }, { 17, 28, -3, 32, -11 }, { 9, 34, 1, -9, -2 } };
            return wait;
        }
    }
}
