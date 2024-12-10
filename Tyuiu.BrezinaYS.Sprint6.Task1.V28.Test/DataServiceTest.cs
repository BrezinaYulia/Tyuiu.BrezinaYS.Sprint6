using Tyuiu.BrezinaYS.Sprint6.Task1.V28.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[] { 4.67, 0.43, -8.26, -9.87, -3.98, 1, 0.02, -1.87, 3.74, 16.43, 24.67 };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}