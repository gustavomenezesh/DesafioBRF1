using Microsoft.VisualStudio.TestTools.UnitTesting;
using sumAlgarismFatorial;

namespace tests
{
    [TestClass]
    public class SumAlgarismFatTests
    {
        [TestMethod]
        public void validFatorial()
        {
            int n = 5;
            int fatorial = 120;

            Assert.AreEqual(fatorial, sumAlgFat.fat(n), 0, "Fatorial not calculed correctly");
            
        }

        [TestMethod]
        public void validSum()
        {
            int n = 120;
            int sum = 3;

            Assert.AreEqual(sum, sumAlgFat.f(n), 0, "Sum not calculed correctly");

        }

        [TestMethod]
        public void validInterval()
        {
            int n = 2001;
            int sum = -1;

            Assert.AreEqual(sum, sumAlgFat.f(n), 0, "range not invalidated");

        }
    }
}
