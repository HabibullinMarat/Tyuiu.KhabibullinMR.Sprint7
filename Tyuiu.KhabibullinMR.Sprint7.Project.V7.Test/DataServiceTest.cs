using Tyuiu.KhabibullinMR.Sprint7.Project.V7.Lib;

namespace Tyuiu.KhabibullinMR.Sprint7.Project.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds, ds);
        }
    }
}
