using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace NumberSystem16UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition16and16()
        {
            Assert.AreEqual("A39", NumberSystem16.Sum("A32", "7"));
        }
        [TestMethod]
        public void Addition16and10()
        {
            Assert.AreEqual("10", NumberSystem16.Sum("B", 5));
        }
        [TestMethod]
        public void Addition10and16()
        {
            Assert.AreEqual("E6", NumberSystem16.Sum(12, "DA"));
        }
        [TestMethod]
        public void AdditionNegative()
        {
            Assert.AreEqual("-A2B", NumberSystem16.Sum("-A32", "7"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AdditionFailInput()
        {
            Assert.Equals(typeof(ArgumentException), NumberSystem16.Sum("10", "3G"));
        }
        [TestMethod]
        public void Substraction16and16()
        {
            Assert.AreEqual("B1", NumberSystem16.Sub("B6", "5"));
        }
        [TestMethod]
        public void Substraction16and10()
        {
            Assert.AreEqual("6", NumberSystem16.Sub("B", 5));
        }
        [TestMethod]
        public void Substraction10and16()
        {
            Assert.AreEqual("2", NumberSystem16.Sub(12, "A"));
        }
        [TestMethod]
        public void SubstractionNegative()
        {
            Assert.AreEqual("-F", NumberSystem16.Sub("-7", "8"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SubstractionFailInput()
        {
            Assert.Equals(typeof(ArgumentException), NumberSystem16.Sub("A4", "3M"));
        }
        [TestMethod]
        public void Conjuction16and16()
        {
            Assert.AreEqual("12", NumberSystem16.And("A32", "57"));
        }
        [TestMethod]
        public void Conjuction16and10()
        {
            Assert.AreEqual("1", NumberSystem16.And("B", 5));
        }
        [TestMethod]
        public void Conjuction10and16()
        {
            Assert.AreEqual("8", NumberSystem16.And(12, "DA"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void ConjuctionFailNegative()
        {
            Assert.Equals(typeof(ArgumentException), NumberSystem16.And("-A32", "7"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConjuctionFailInput()
        {
            Assert.Equals(typeof(ArgumentException), NumberSystem16.And("V", "3"));
        }
        [TestMethod]
        public void Disjunction16and16()
        {
            Assert.AreEqual("A77", NumberSystem16.Or("A32", "57"));
        }
        [TestMethod]
        public void Disjunction16and10()
        {
            Assert.AreEqual("F", NumberSystem16.Or("B", 5));
        }
        [TestMethod]
        public void Disjunction10and16()
        {
            Assert.AreEqual("DE", NumberSystem16.Or(12, "DA"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void DisjunctionFailNegative()
        {
            Assert.Equals(typeof(ArgumentException), NumberSystem16.Or("-A32", "7"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DisjunctionFailInput()
        {
            Assert.Equals(typeof(ArgumentException), NumberSystem16.Or("V", "K"));
        }
    }
}
