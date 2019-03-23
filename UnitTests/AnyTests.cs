using AnyDataType;
using NUnit.Framework;
using System;

namespace AnyTests
{
	[TestFixture()]
	public class AnyTests
	{
		public class AnyString
		{
			[Test]
			public void AnyStringEqualsString()
			{
				Any custom = "test";
				Assert.AreEqual("test", custom);
				Assert.IsTrue("test" == custom);
			}

			[Test]
			public void AnyStringNotEqualsString()
			{
				Any custom = "other";
				Assert.AreNotEqual("test", custom);
				Assert.IsFalse("test" == custom);
			}

			[Test]
			public void AnyStringEqualsInt()
			{
				Any custom = "5";
				Assert.AreEqual(5, custom);
				Assert.IsTrue(5 == custom);
			}

			[Test]
			public void AnyStringEqualsAnyString()
			{
				Any test = "test";
				Any other = "test";
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyStringNotEqualsAnyString()
			{
				Any test = "test";
				Any other = "other";
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}
		}

		public class AnyInt
		{
			[Test]
			public void AnyIntEqualsInt()
			{
				Any custom = 5;
				Assert.AreEqual(5, custom);
				Assert.IsTrue(5 == custom);
			}

			[Test]
			public void AnyIntNotEqualsInt()
			{
				Any custom = 5;
				Assert.AreNotEqual(6, custom);
				Assert.IsFalse(6 == custom);
			}

			[Test]
			public void AnyIntEqualsString()
			{
				Any custom = 5;
				Assert.AreEqual("5", custom);
				Assert.IsTrue("5" == custom);
			}

			[Test]
			public void AnyIntNotEqualsString()
			{
				Any custom = 5;
				Assert.AreNotEqual("6", custom);
				Assert.IsFalse("6" == custom);
			}

			[Test]
			public void AnyIntEqualsAnyInt()
			{
				Any test = 5;
				Any other = 5;
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyIntNotEqualsAnyInt()
			{
				Any test = 5;
				Any other = 6;
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}
		}


		public class AnyDouble
		{
			[Test]
			public void AnyDoubleEqualsDouble()
			{
				Any test = 2.22;
				Assert.AreEqual(2.22, test);
				Assert.IsTrue(2.22 == test);
			}

			[Test]
			public void AnyDoubleNotEqualsDouble()
			{
				Any test = 2.22;
				Assert.AreNotEqual(3.22, test);
				Assert.IsFalse(3.22 == test);
			}

			[Test]
			public void AnyDoubleEqualString()
			{
				Any test = 2.22;
				Assert.AreEqual("2.22", test);
				Assert.IsTrue("2.22" == test);
			}

			[Test]
			public void AnyDoubleNotEqualString()
			{
				Any test = 2.22;
				Assert.AreNotEqual("3.22", test);
				Assert.IsFalse("3.22" == test);
			}

			[Test]
			public void AnyDoubleEqualAnyDouble()
			{
				Any test = 2.22;
				Any other = 2.22;
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyDoubleNotEqualAnyDouble()
			{
				Any test = 2.22;
				Any other = 3.22;
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}

			[Test]
			public void AnyDoubleEqualAnyString()
			{
				Any test = 2.22;
				Any other = "2.22";
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyDoubleNotEqualAnyString()
			{
				Any test = 2.22;
				Any other = "3.22";
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}
		}

		public class AnyLong
		{
			[Test]
			public void AnyLongEqualsLong()
			{
				Any test = 2L;
				Assert.AreEqual(2L, test);
				Assert.IsTrue(2L == test);
			}

			[Test]
			public void AnyLongNotEqualsLong()
			{
				Any test = 2L;
				Assert.AreNotEqual(3L, test);
				Assert.IsFalse(3L == test);
			}

			[Test]
			public void AnyLongEqualString()
			{
				Any test = 2L;
				Assert.AreEqual("2", test);
				Assert.IsTrue("2" == test);
			}

			[Test]
			public void AnyLongNotEqualString()
			{
				Any test = 2L;
				Assert.AreNotEqual("3", test);
				Assert.IsFalse("3" == test);
			}

			[Test]
			public void AnyLongEqualAnyLong()
			{
				Any test = 2L;
				Any other = 2L;
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyLongNotEqualAnyLong()
			{
				Any test = 2L;
				Any other = 3L;
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}

			[Test]
			public void AnyLongEqualAnyString()
			{
				Any test = 2L;
				Any other = "2";
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyLongNotEqualAnyString()
			{
				Any test = 2L;
				Any other = "3";
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}
		}

		public class AnyDecimal
		{
			[Test]
			public void AnyDecimalEqualsDecimal()
			{
				Any test = 2.22m;
				Assert.AreEqual(2.22m, test);
				Assert.IsTrue(2.22m == test);
			}

			[Test]
			public void AnyDecimalNotEqualsDecimal()
			{
				Any test = 2.22m;
				Assert.AreNotEqual(3.22m, test);
				Assert.IsFalse(3.22m == test);
			}

			[Test]
			public void AnyDecimalEqualString()
			{
				Any test = 2.22m;
				Assert.AreEqual("2.22", test);
				Assert.IsTrue("2.22" == test);
			}

			[Test]
			public void AnyDecimalNotEqualString()
			{
				Any test = 2.22m;
				Assert.AreNotEqual("3", test);
				Assert.IsFalse("3" == test);
			}

			[Test]
			public void AnyDecimalEqualAnyDecimal()
			{
				Any test = 2.22m;
				Any other = 2.22m;
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyDecimalNotEqualAnyDecimal()
			{
				Any test = 2.22m;
				Any other = 3.22m;
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}

			[Test]
			public void AnyDecimalEqualAnyString()
			{
				Any test = 2.22m;
				Any other = "2.22";
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyDecimalNotEqualAnyString()
			{
				Any test = 2.22m;
				Any other = "3.22";
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}
		}

		public class AnyFloat
		{
			[Test]
			public void AnyFloatEqualsFloat()
			{
				Any test = 2.22f;
				Assert.AreEqual(2.22f, test);
				Assert.IsTrue(2.22f == test);
			}

			[Test]
			public void AnyFloatNotEqualsFloat()
			{
				Any test = 2.22f;
				Assert.AreNotEqual(3.22f, test);
				Assert.IsFalse(3.22f == test);
			}

			[Test]
			public void AnyFloatEqualString()
			{
				Any test = 2.22f;
				Assert.AreEqual("2.22", test);
				Assert.IsTrue("2.22" == test);
			}

			[Test]
			public void AnyFloatNotEqualString()
			{
				Any test = 2.22f;
				Assert.AreNotEqual("3.22", test);
				Assert.IsFalse("3.22" == test);
			}

			[Test]
			public void AnyFloatEqualAnyFloat()
			{
				Any test = 2.22f;
				Any other = 2.22f;
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyFloatNotEqualAnyFloat()
			{
				Any test = 2.22f;
				Any other = 3.22f;
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}

			[Test]
			public void AnyFloatEqualAnyString()
			{
				Any test = 2.22f;
				Any other = "2.22";
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyFloatNotEqualAnyString()
			{
				Any test = 2.22f;
				Any other = "3.22";
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}
		}

		public class AnyDateTime
		{
			[Test]
			public void AnyDateTimeEqualsDateTime()
			{
				var date = DateTime.Parse("2019/04/11");
				Any test = date;
				Assert.AreEqual(date, test);
				Assert.IsTrue(date == test);
			}

			[Test]
			public void AnyDateTimeNotEqualsDateTime()
			{
				var date = DateTime.Parse("2019/04/11");
				var other = DateTime.Parse("2019/05/11");
				Any test = date;
				Assert.AreNotEqual(other, test);
				Assert.IsFalse(other == test);
			}

			[Test]
			public void AnyDateTimeEqualString()
			{
				var date = DateTime.Parse("2019/04/11");
				var other = "2019/04/11";
				Any test = date;
				Assert.AreEqual(other, test);
				Assert.IsTrue(other == test);
			}

			[Test]
			public void AnyDateTimeNotEqualString()
			{
				var date = DateTime.Parse("2019/04/11");
				var other = "2019/05/11";
				Any test = date;
				Assert.AreNotEqual(other, test);
				Assert.IsFalse(other == test);
			}

			[Test]
			public void AnyDateTimeEqualAnyDateTime()
			{
				var date = DateTime.Parse("2019/04/11");
				Any test = date;
				Any other = date;
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyDateTimeNotEqualAnyDateTime()
			{
				var date = DateTime.Parse("2019/04/11");
				var otherDate = DateTime.Parse("2019/05/11");
				Any test = date;
				Any other = otherDate;
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}

			[Test]
			public void AnyDateTimeEqualAnyString()
			{
				var date = DateTime.Parse("2019/04/11");
				Any test = date;
				Any other = "2019/04/11";
				Assert.AreEqual(test, other);
				Assert.IsTrue(test == other);
			}

			[Test]
			public void AnyDateTimeNotEqualAnyString()
			{
				var date = DateTime.Parse("2019/04/11");
				Any test = date;
				Any other = "rubbish";
				Assert.AreNotEqual(test, other);
				Assert.IsFalse(test == other);
			}
		}

		public class AnyIntMultiplication
		{
			[Test]
			public void MultiplicationInt()
			{
				Any test = 5;
				Assert.AreEqual(20, test * 4);
			}

			[Test]
			public void MultiplicationLong()
			{
				Any test = 5;
				Assert.AreEqual(20, test * 4L);
			}

			[Test]
			public void MultiplicationDouble()
			{
				Any test = 4;
				Assert.AreEqual(10, test * 2.5);
			}

			[Test]
			public void MultiplicationFloat()
			{
				Any test = 4;
				Assert.AreEqual(10, test * 2.5f);
			}

			[Test]
			public void MultiplicationDecimal()
			{
				Any test = 4;
				Assert.AreEqual(10, test * 2.5m);
			}

			[Test]
			public void MultiplicationAnyInt()
			{
				Any test = 5;
				Any other = 4;
				Assert.AreEqual(20, test * other);
			}

			[Test]
			public void MultiplicationAnyLong()
			{
				Any test = 5;
				Any other = 4L;
				Assert.AreEqual(20, test * other);
			}

			[Test]
			public void MultiplicationAnyDouble()
			{
				Any test = 4;
				Any other = 2.5;
				Assert.AreEqual(10.0, test * other);
			}

			[Test]
			public void MultiplicationAnyFloat()
			{
				Any test = 4;
				Any other = 2.5f;
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicatioAnyDecimal()
			{
				Any test = 4;
				Any other = 2.5m;
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicatioAnyString()
			{
				Any test = 4;
				Any other = "2.5";
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicatioAnyStringAnyString()
			{
				Any test = "4";
				Any other = "2.5";
				Assert.AreEqual(10, test * other);
			}
		}

		public class AnyLongMultiplication
		{
			[Test]
			public void MultiplicationInt()
			{
				Any test = 5L;
				Assert.AreEqual(20, test * 4);
			}

			[Test]
			public void MultiplicationLong()
			{
				Any test = 5L;
				Assert.AreEqual(20, test * 4L);
			}

			[Test]
			public void MultiplicationDouble()
			{
				Any test = 4L;
				Assert.AreEqual(10, test * 2.5);
			}

			[Test]
			public void MultiplicationFloat()
			{
				Any test = 4L;
				Assert.AreEqual(10, test * 2.5f);
			}

			[Test]
			public void MultiplicationDecimal()
			{
				Any test = 4L;
				Assert.AreEqual(10, test * 2.5m);
			}

			[Test]
			public void MultiplicationAnyInt()
			{
				Any test = 5L;
				Any other = 4L;
				Assert.AreEqual(20, test * other);
			}

			[Test]
			public void MultiplicationAnyLong()
			{
				Any test = 5L;
				Any other = 4L;
				Assert.AreEqual(20, test * other);
			}

			[Test]
			public void MultiplicationAnyDouble()
			{
				Any test = 4L;
				Any other = 2.5;
				Assert.AreEqual(10.0, test * other);
			}

			[Test]
			public void MultiplicationAnyFloat()
			{
				Any test = 4L;
				Any other = 2.5f;
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicatioAnyDecimal()
			{
				Any test = 4L;
				Any other = 2.5m;
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicatioAnyString()
			{
				Any test = 4L;
				Any other = "2.5";
				Assert.AreEqual(10, test * other);
			}
		}

		public class AnyFloatMultiplication
		{
			[Test]
			public void MultiplicationInt()
			{
				Any test = 5.5f;
				Assert.AreEqual(22, test * 4);
			}

			[Test]
			public void MultiplicationLong()
			{
				Any test = 5.5f;
				Assert.AreEqual(22, test * 4L);
			}

			[Test]
			public void MultiplicationDouble()
			{
				Any test = 4f;
				Assert.AreEqual(10, test * 2.5);
			}

			[Test]
			public void MultiplicationFloat()
			{
				Any test = 4f;
				Assert.AreEqual(10, test * 2.5f);
			}

			[Test]
			public void MultiplicationDecimal()
			{
				Any test = 4f;
				Assert.AreEqual(10, test * 2.5m);
			}

			[Test]
			public void MultiplicationAnyInt()
			{
				Any test = 5f;
				Any other = 4f;
				Assert.AreEqual(20, test * other);
			}

			[Test]
			public void MultiplicationAnyLong()
			{
				Any test = 5f;
				Any other = 4f;
				Assert.AreEqual(20, test * other);
			}

			[Test]
			public void MultiplicationAnyDouble()
			{
				Any test = 4f;
				Any other = 2.5;
				Assert.AreEqual(10.0, test * other);
			}

			[Test]
			public void MultiplicationAnyFloat()
			{
				Any test = 4f;
				Any other = 2.5f;
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicatioAnyDecimal()
			{
				Any test = 4f;
				Any other = 2.5m;
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicatioAnyString()
			{
				Any test = 4f;
				Any other = "2.5";
				Assert.AreEqual(10, test * other);
			}
		}

		public class AnyDecimalMultiplication
		{
			[Test]
			public void MultiplicationInt()
			{
				Any test = 5f;
				Assert.AreEqual(20, test * 4);
			}

			[Test]
			public void MultiplicationLong()
			{
				Any test = 5f;
				Assert.AreEqual(20, test * 4L);
			}

			[Test]
			public void MultiplicationDouble()
			{
				Any test = 4m;
				Assert.AreEqual(10, test * 2.5);
			}

			[Test]
			public void MultiplicationFloat()
			{
				Any test = 4m;
				Assert.AreEqual(10, test * 2.5f);
			}

			[Test]
			public void MultiplicationDecimal()
			{
				Any test = 4m;
				Assert.AreEqual(10, test * 2.5m);
			}

			[Test]
			public void MultiplicationAnyInt()
			{
				Any test = 5m;
				Any other = 4m;
				Assert.AreEqual(20, test * other);
			}

			[Test]
			public void MultiplicationAnyLong()
			{
				Any test = 5m;
				Any other = 4m;
				Assert.AreEqual(20, test * other);
			}

			[Test]
			public void MultiplicationAnyDouble()
			{
				Any test = 4m;
				Any other = 2.5;
				Assert.AreEqual(10.0, test * other);
			}

			[Test]
			public void MultiplicationAnyFloat()
			{
				Any test = 4m;
				Any other = 2.5f;
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicationAnyDecimal()
			{
				Any test = 4m;
				Any other = 2.5m;
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicationAnyString()
			{
				Any test = 4m;
				Any other = "2.5";
				Assert.AreEqual(10, test * other);
			}

			[Test]
			public void MultiplicationString()
			{
				Any test = 4m;
				Assert.AreEqual(10, "2.5" * test);
			}
		}

		public class Addition
		{
			[Test]
			public void AdditionInt()
			{
				Any test = 4;
				Assert.AreEqual(9, 5 + test);
			}

			[Test]
			public void AdditionDecimal()
			{
				Any test = 4;
				Assert.AreEqual(9.2, 5.2m + test);
			}

			[Test]
			public void AdditionAnyString()
			{
				Any test = 4;
				Any str = "5";
				Assert.AreEqual(9, str + test);
			}

			[Test]
			public void AdditionString()
			{
				Any test = 4;
				Assert.AreEqual(9,  "5" + test);
			}

			[Test]
			public void StringConcatenation()
			{
				Any test = 4;
				Assert.AreEqual("test4", "test" + test);
				test = "test";
				Any other = "other";
				Assert.AreEqual("testother", test + other);
			}
		}

		public class Subtraction
		{
			[Test]
			public void SubtractionInt()
			{
				Any test = 4;
				Assert.AreEqual(1, 5 - test);
			}

			[Test]
			public void SubtractionDecimal()
			{
				Any test = 4;
				Assert.AreEqual(1.2, 5.2m - test, .00001);
			}

			[Test]
			public void SubtractionAnyString()
			{
				Any test = 4;
				Any str = "5";
				Assert.AreEqual(1, str - test);
			}

			[Test]
			public void SubtractionString()
			{
				Any test = 4;
				Assert.AreEqual(1, "5" - test);
			}
		}

		public class Division
		{
			[Test]
			public void DivisionInt()
			{
				Any test = 16;
				Assert.AreEqual(4, test / 4);
			}

			[Test]
			public void DivisionDecimal()
			{
				Any test = 16;
				Assert.AreEqual(4, test / 4m);
			}

			[Test]
			public void DivisionAnyString()
			{
				Any test = 16;
				Any str = "4";
				Assert.AreEqual(4, test / str);
			}

			[Test]
			public void DivisionString()
			{
				Any test = 16;
				Any divisor = "4";
				Assert.AreEqual(4, test / "4");
				Assert.AreEqual(4, 16/divisor);
			}
		}
	}
}
