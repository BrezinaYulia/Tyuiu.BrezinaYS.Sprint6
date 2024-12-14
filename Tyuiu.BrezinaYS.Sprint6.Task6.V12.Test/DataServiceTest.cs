using Tyuiu.BrezinaYS.Sprint6.Task6.V12.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V12.txt";
            string res = ds.CollectTextFromFile("w", path);
            string wait = " iKDOjtfsPmw";
            Assert.AreEqual(wait, res);
        }
    }
}