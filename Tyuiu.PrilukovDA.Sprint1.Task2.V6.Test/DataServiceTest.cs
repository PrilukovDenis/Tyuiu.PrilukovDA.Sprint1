using Tyuiu.PrilukovDA.Sprint1.Task2.V6.Lib;

namespace Tyuiu.PrilukovDA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1000;

            Assert.AreEqual(1, ds.ConvertMToKm(x));
        }
    }
}
