using Tyuiu.GroshevID.Sprint2.Task6.V12.Lib;

namespace Tyuiu.GroshevID.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int g = 2007;
            int m = 13;
            int n = 9;

            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "2007.5.8";

            Assert.AreEqual(wait, res);

            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                ds.FindDateOfPreviousDay(g, 13, n);
            });
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                ds.FindDateOfPreviousDay(g, -1, n);
            });
        }
    }
}
