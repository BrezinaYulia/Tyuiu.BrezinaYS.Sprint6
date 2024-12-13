using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrezinaYS.Sprint6.Task4.V2.Lib
{
    public class DataService : ISprint6Task4V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] value;
            int len = (stopValue - startValue) + 1;
            value = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12 * x + 2, 2);
                value[count] = y;
                count++;
            }
            return value;
        }
    }
}
