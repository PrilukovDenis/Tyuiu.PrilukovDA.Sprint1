using Tyuiu.PrilukovDA.Sprint1.Task3.V18.Lib;

namespace Tyuiu.PrilukovDA.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 2;
            double b = 2;
            double c = 1;
            Assert.AreEqual(4, ds.HowManySquares(a, b, c));
        }
    }
}
