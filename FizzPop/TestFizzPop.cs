using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FizzPop
{
    [TestClass]
    public class TestFizzPop
    {
        private readonly FizzPopper _fizzPopper = new FizzPopper();

        [TestMethod]
        public void NumberNotDivisableBySevenOrNotContainingNine_ReturnsNumber()
        {
            Assert.AreEqual(_fizzPopper[81], "81");
        }

        [TestMethod]
        public void NumberDivisableBySeven_ReturnsFizz()
        {
            Assert.AreEqual(_fizzPopper[7], "Fizz");
        }

        [TestMethod]
        public void NumberContainingNine_ReturnsPop()
        {
            Assert.AreEqual(_fizzPopper[19], "Pop");
        }

        [TestMethod]
        public void NumberDivisableBySevenAndContainingNine_ReturnsFizzPop()
        {
            Assert.AreEqual(_fizzPopper[49], "FizzPop");
        }

        [TestMethod]
        public void NumberDivisableBySevenAndDiviableNineAndNotContainingNine_ReturnsFizz()
        {
            Assert.AreEqual(_fizzPopper[63], "Fizz");
        }

        [TestMethod]
        public void RangeMustCountTheRange()
        {
            Assert.AreEqual(100, _fizzPopper.Range(1, 100).Count());
        }
    }
}
