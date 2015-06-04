using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzPop
{
    [TestClass]
    public class TestFizzPop
    {
        private readonly FizzPopper _fizzPopper = new FizzPopper();

        [TestMethod]
        public void NumberNotDivisableBySevenOrNine_ReturnsSameNumber()
        {
            Assert.AreEqual(_fizzPopper[5], "5");
        }

        [TestMethod]
        public void NumberDivisableBySeven_ReturnsFizz()
        {
        }
    }
}
