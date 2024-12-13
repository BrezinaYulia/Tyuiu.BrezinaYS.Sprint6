using Tyuiu.BrezinaYS.Sprint6.Task5.V24.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask5V24.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 0, 0};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}