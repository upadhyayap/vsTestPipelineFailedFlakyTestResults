using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlakyTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private static int _value = 0;

        [TestMethod]
        [Priority(0)]
        public void TestMethod1()
        {
            Assert.IsTrue(_value %2 == 0);
            _value++;
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod2()
        {
            Assert.IsTrue(_value %2 == 0);
            _value++;
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod3()
        {
            Assert.IsTrue(_value %2 == 0);
            _value++;
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod4()
        {
            Assert.IsTrue(_value %2 == 0);
            _value++;
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod5()
        {
            //Always pass
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod6()
        {
            //Always pass
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod7()
        {
            Assert.IsTrue(false, "It will always fail");
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod8()
        {
            Assert.IsTrue(false, "It will always fail");
        }
    }
}
