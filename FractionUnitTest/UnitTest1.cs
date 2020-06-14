using System;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace FractionUnitTest 
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void tostringtest() 
		{
			var v1 = new Fraction(2, 4);
			Assert.AreEqual("1/2", v1.ToString());	
		}

		[TestMethod]
		public void isFractiontest()
		{
			const string error = "В знаменателе не может быть нуля";
			try
			{
				var v1 = new Fraction(2, 0);
				Assert.Fail("error");
			}
			catch(Exception ex)
			{
				Assert.AreEqual(ex.Message, error);
			}
		}
		

		[TestMethod]
		public void equalstest()
		{
			var v1 = new Fraction(2, -4);
			var v2 = new Fraction(-2, 4);
			bool expected = true;
			bool actual = Fraction.Equals(v1, v2);
			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void equalstest1()
		{
			var v1 = new Fraction(2, 4);
			var v2 = v1;
			Assert.AreEqual(v1, v2);
		}

		[TestMethod]
		public void nodtsest()
		{
			int v1 = 2;
			int v2 = 4;
			var v3 = Fraction.NOD(v1, v2);
			Assert.AreEqual(v3, v1);

		}
        
		[TestMethod]
		public void nodtestwithzero()
		{
			int v1 = 2;
			int v2 = 0;
			int v3 = Fraction.NOD(v1, v2);
			int expected = 0;
			Assert.AreEqual(v3, expected);
		}

		[TestMethod]
		public void numeratortest()
		{
			var v1 = new Fraction(2, 4);
			int expected = 1;
			Assert.AreEqual(v1.Numerator, expected);
		}
		[TestMethod]
		public void denominatortest()
		{
			var v1 = new Fraction(2, 4);
			int expected = 2;
			Assert.AreEqual(v1.Denominator, expected);
		}
		[TestMethod]
		public void reductiontest()
		{
			var v1 = new Fraction(2, 4);
			var expected = new Fraction(1, 2);
			Assert.AreEqual(v1.ToString(),expected.ToString());
			
		}
		[TestMethod]
		public void plus_opearatortest()
		{
			var v1 = new Fraction(1, 3);
			var v2 = new Fraction(1, 3);
			var expected = new Fraction(2, 3);
			Assert.AreEqual((v1 + v2).ToString(), (expected).ToString());
		}

		
		[TestMethod]
		public void minus_operatortest()
		{
			var v1 = new Fraction(3, 4);
			var v2 = new Fraction(1, 4);
			var expected = new Fraction(2, 4);
			Assert.AreEqual((v1 - v2).ToString(), expected.ToString());
		}

		

		[TestMethod]
		public void minus_testoperator1()
		{
			var v1 = new Fraction(1, 2);
			var v2 = new Fraction(1, 2);
			var expected = new Fraction(0, 0);
			Assert.AreEqual((v1 - v2).ToString(), expected.ToString());
		}

		[TestMethod]
		public void multiplication_operatortest()
		{
			var v1 = new Fraction(1, 5);
			var v2 = new Fraction(2, 4);
			var expected = new Fraction(2, 20);
			Assert.AreEqual((v1 * v2).ToString(), expected.ToString());
		}

		[TestMethod]
		public void multiplication_operatorwithzero()
		{
			var v1 = new Fraction(1, 5);
			var v2 = new Fraction(0, 0);
			var expected = new Fraction(0, 0);
			Assert.AreEqual((v1 * v2).ToString(), expected.ToString());
		}

		[TestMethod]
		public void division_operatortest()
		{
			var v1 = new Fraction(3, 5);
			var v2 = new Fraction(7, 11);
			var expected = new Fraction(33, 35);
			Assert.AreEqual((v1 / v2).ToString(), expected.ToString());
		}

		[TestMethod]
		public void division_operatorwithzero()
		{
			var v1 = new Fraction(0, 0);
			var v2 = new Fraction(1, 5);
			var expected = new Fraction(0, 0);
			Assert.AreEqual((v1 / v2).ToString(), expected.ToString());
		}

		[TestMethod]
		public void pow_operatortwithzero1()
		{
			var v1 = new Fraction(3, 4);
			var expected = new Fraction(1, 1);
			Assert.AreEqual(Fraction.Pow(v1, 0).ToString(), expected.ToString());
		}

		[TestMethod]
        public void pow_operatorwithzero2()
		{
			var v1 = new Fraction(0, 0);
			var expected = new Fraction(0, 0);
			Assert.AreEqual(Fraction.Pow(v1, 2).ToString(), expected.ToString());
		}

		[TestMethod]
		public void pow_operatortest()
		{
			var v1 = new Fraction(1, 2);
			var expected = new Fraction(1, 4);
			Assert.AreEqual(Fraction.Pow(v1, 2).ToString(), expected.ToString());
		}
	}
}
