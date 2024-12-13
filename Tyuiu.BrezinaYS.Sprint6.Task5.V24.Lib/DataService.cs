using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.BrezinaYS.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    numArray[index] = Convert.ToDouble(line);
                    index++;

                }
            }
            numArray = numArray.Where(val => val == 0).ToArray();
            return numArray;
        }
        
        
    }
}
