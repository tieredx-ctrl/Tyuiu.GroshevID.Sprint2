using Tyuiu.GroshevID.Sprint2.Task5.V8.Lib;

namespace Tyuiu.GroshevID.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int n = 6;

            Assert.AreEqual("5 января", ds.FindDateOfPreviousDay(1, n));
            Assert.AreEqual("5 февраля", ds.FindDateOfPreviousDay(2, n));
            Assert.AreEqual("5 марта", ds.FindDateOfPreviousDay(3, n));
            Assert.AreEqual("5 апреля", ds.FindDateOfPreviousDay(4, n));
            Assert.AreEqual("5 мая", ds.FindDateOfPreviousDay(5, n));
            Assert.AreEqual("5 июня", ds.FindDateOfPreviousDay(6, n));
            Assert.AreEqual("5 июля", ds.FindDateOfPreviousDay(7, n));
            Assert.AreEqual("5 августа", ds.FindDateOfPreviousDay(8, n));
            Assert.AreEqual("5 сентября", ds.FindDateOfPreviousDay(9, n));
            Assert.AreEqual("5 октября", ds.FindDateOfPreviousDay(10, n));
            Assert.AreEqual("5 ноября", ds.FindDateOfPreviousDay(11, n));
            Assert.AreEqual("5 декабря", ds.FindDateOfPreviousDay(12, n));

            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                ds.FindDateOfPreviousDay(-1, n);
            });
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                ds.FindDateOfPreviousDay(13, n);
            });
        }
    }
}
