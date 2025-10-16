using Tyuiu.YachmenevaPV.Sprint2.Task7.V14.Lib;
namespace Tyuiu.YachmenevaPV.Sprint2.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            double x = 0.25;
            double y = 0.25;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
