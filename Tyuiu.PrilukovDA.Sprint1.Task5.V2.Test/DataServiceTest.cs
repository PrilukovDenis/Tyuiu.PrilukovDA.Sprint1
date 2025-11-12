using Tyuiu.PrilukovDA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.PrilukovDA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-18, ds.FahrenheitToСelsius(0));
        }
    }
}
