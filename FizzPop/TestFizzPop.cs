﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            Assert.AreEqual(_fizzPopper[7], "Fizz");
        }

        [TestMethod]
        public void NumberDivisableByNine_ReturnsPop()
        {
            Assert.AreEqual(_fizzPopper[9], "Pop");
        }

        [TestMethod]
        public void NumberDivisableBySevenAndNine_ReturnsFizzPop()
        {
            Assert.AreEqual(_fizzPopper[63], "FizzPop");
        }

        [TestMethod]
        public void RangeMustCountTheRange()
        {
            Assert.AreEqual(100, _fizzPopper.Range(1, 100).Count());
        }
    }
}
