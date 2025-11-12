using Tyuiu.PrilukovDA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.PrilukovDA.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckLastWordRepetiton("привет мир привет"));
        }
    }
}
