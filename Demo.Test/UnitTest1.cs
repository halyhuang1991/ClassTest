namespace Demo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           StringAssert.Contains("ok","o");
           //Assert.AreEqual(1,2);
        }
        [TestMethod]
        public void TestMethod2()
        {
           Assert.AreEqual(1,1);
        }
        [TestMethod]
        public void TestMethod3()
        {
           Assert.AreEqual(1,2);
        }
        
    }
}
