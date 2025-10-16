using Tyuiu.GroshevID.Sprint2.Task4.V24.Lib;

namespace Tyuiu.GroshevID.Sprint2.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 98;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 0.833;
            Assert.AreEqual(wait, res);
        }
    }
}
