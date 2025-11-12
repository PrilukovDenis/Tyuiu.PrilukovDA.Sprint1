using Tyuiu.PrilukovDA.Sprint1.Task7.V5.Lib;

namespace Tyuiu.PrilukovDA.Sprint1.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.545, ds.Calculate(2));
        }
    }
}
