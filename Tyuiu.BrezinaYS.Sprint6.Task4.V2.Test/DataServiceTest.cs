using Tyuiu.BrezinaYS.Sprint6.Task4.V2.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task4.V2.Test
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
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 59.49, 38.47, -2.81, -19.67, -8.42, 0.57, -6.3, -20.14, -3.51, 38.13, 59.6 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}