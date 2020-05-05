using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 5, 6, 10, 2, 6 };
            string result = main.Program.mainProg(arr);
            Assert.AreEqual((8 + " " + 3), result);
        }
    }
}
