using Tyuiu.BrezinaYS.Sprint6.Task2.V3.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task2.V3.Test
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
            double[] wait = new double[] { -12.18, 16.03, 18.87, 4.96, -9.99, -2, 2.16, -7.54, -22.76, -20.45, 7.77 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}