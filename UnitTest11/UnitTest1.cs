using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest11
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            int d = 357;
            int result = ConsoleApp1.Program.Result(d);
            int result1 = ConsoleApp1.Program.Result1(d);
            Assert.AreEqual(3, result);
            Assert.AreEqual(7, result1);
        }
    }
}
