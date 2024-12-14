using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrezinaYS.Sprint6.Task7.V7.Lib
{
    public class DataService : ISprint6Task7V7
    {
 

        public int[,] GetMatrix(string path)
        {
            string[] mass = File.ReadAllLines(path);
            int s = 10;
            for (int i = 0; i < s; i++)
            {
                mass[i] = mass[i].Replace(";", " ");
            }

            int[,] matrix = new int[s, s];
            for (int i = 0; i < s; i++)
            {
                int[] row = mass[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < s; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int[,] res = new int[s, s];
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;
            int xCol = 4;
            for (int c = 0; c < col; c++)
            {
                for (int r = xCol; r <= xCol; r++)
                {
                    if ((matrix[r, c] % 2) != 0)
                    {
                        matrix[r, c] = 66;
                    }
                }
            }
            return matrix;
        }
    }
}
