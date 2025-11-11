using Tyuiu.PrilukovDA.Sprint1.Task1.V16.Lib;

namespace Tyuiu.PrilukovDA.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double x = 1;
            double y = 2;
            double a = 3;
            Assert.AreEqual(16, dataService.Calculate(x, y, a));
        }
    }
}
