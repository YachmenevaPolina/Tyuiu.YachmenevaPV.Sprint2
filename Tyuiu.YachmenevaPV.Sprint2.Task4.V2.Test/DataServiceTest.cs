using Tyuiu.YachmenevaPV.Sprint2.Task4.V2.Lib;
namespace Tyuiu.YachmenevaPV.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 9.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 1.3;
            Assert.AreEqual(wait, res);
        }
    }
}
