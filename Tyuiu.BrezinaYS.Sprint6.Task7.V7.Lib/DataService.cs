using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrezinaYS.Sprint6.Task7.V7.Lib
{
    public class DataService : ISprint6Task7V7
    {
        public int[,] GetMatrix(int[,] matrix)
        {
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
