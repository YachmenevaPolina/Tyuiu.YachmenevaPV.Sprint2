using Tyuiu.YachmenevaPV.Sprint2.Task6.V11.Lib;
namespace Tyuiu.YachmenevaPV.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2004;
            int m = 4;
            int n = 1;
            Assert.AreEqual("31.03.2004", ds.FindDateOfNextDay(g, m, n));


        }
    }
}
