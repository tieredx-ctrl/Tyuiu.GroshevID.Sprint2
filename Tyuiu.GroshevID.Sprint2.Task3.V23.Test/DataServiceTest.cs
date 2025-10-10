using Tyuiu.GroshevID.Sprint2.Task3.V23.Lib;

namespace Tyuiu.GroshevID.Sprint2.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -16/3;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 3;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -28;
            double res = ds.Calculate(x);
            double wait = -308 - (1/784);
            Assert.AreEqual(wait, res);
        }
    }
}
