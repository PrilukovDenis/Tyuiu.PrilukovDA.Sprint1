using Tyuiu.PrilukovDA.Sprint1.Task0.V5.Lib;

namespace Tyuiu.PrilukovDA.Sprint1.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(12, dataService.Calculate());
        }
    }
}
