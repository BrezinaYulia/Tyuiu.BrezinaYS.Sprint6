using Tyuiu.BrezinaYS.Sprint6.Task7.V7.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix =  { { 94, 37, 28, 1 }, { 56, 12, -7, 8 }, { 8, 9, 5, 3 }, { 55, 33, 12, 70 }, { 96, 33, 27, 1 }, { 8, 51, 33, 6 } };
            int[,] res = ds.GetMatrix(matrix);
            int[,] wait = { { 94, 37, 28, 1 }, { 56, 12, -7, 8 }, { 8, 9, 5, 3 }, { 55, 33, 12, 70 }, { 96, 66, 66, 66 }, { 8, 51, 33, 6 } };
            CollectionAssert.AreEqual(wait, res);
        
        }
    }
}