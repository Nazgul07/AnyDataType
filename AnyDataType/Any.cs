using System;
using System.Text;

namespace AnyDataType
{
	public struct Any : IEquatable<Any>, IEquatable<string>, IEquatable<int>, IEquatable<long>, IEquatable<float>, IEquatable<double>, IEquatable<decimal>, IEquatable<DateTime>
	{
		private object _value;

		#region Implicit  Assignments

		public static implicit operator Any(string value)
		{
			return new Any { _value = value };
		}

		public static implicit operator Any(int value)
		{
			return new Any { _value = value };
		}

		public static implicit operator Any(long value)
		{
			return new Any { _value = value };
		}

		public static implicit operator Any(float value)
		{
			return new Any { _value = value };
		}

		public static implicit operator Any(double value)
		{
			return new Any { _value = value };
		}

		public static implicit operator Any(decimal value)
		{
			return new Any { _value = value };
		}

		public static implicit operator Any(DateTime value)
		{
			return new Any { _value = value };
		}

		#endregion

		#region Equality

		public static bool operator ==(Any left, Any right)
		{
			return left.Equals(right._value);
		}

		public static bool operator !=(Any left, Any right)
		{
			return !(left._value == right._value);
		}

		public bool Equals(string other)
		{
			return Equals((object)other);
		}

		public bool Equals(int other)
		{
			return Equals((object)other);
		}

		public bool Equals(long other)
		{
			return Equals((object)other);
		}

		public bool Equals(float other)
		{
			return Equals((object)other);
		}

		public bool Equals(double other)
		{
			return Equals((object)other);
		}

		public bool Equals(decimal other)
		{
			return Equals((object)other);
		}

		public bool Equals(DateTime other)
		{
			return Equals((object)other);
		}

		public bool Equals(Any other)
		{
			return Equals(other._value);
		}

		private static bool IsNumber(object value)
		{
			return value is int
					|| value is long
					|| value is float
					|| value is double
					|| value is decimal;
		}

		private bool AreEqual(object left, object right)
		{
			if (IsNumber(left) && IsNumber(right))
			{
				return ((IConvertible)left).ToDouble(null) == ((IConvertible)right).ToDouble(null);
			}
			switch (left)
			{
				case string strLeft when right is string strRight:
					return strLeft == strRight;
				case string strLeft when right is int intRight:
					{
						if (int.TryParse(strLeft, out int intLeft)) return intLeft == intRight;
					}
					break;
				case string strLeft when right is long longRight:
					{
						if (long.TryParse(strLeft, out long longLeft)) return longLeft == longRight;
					}
					break;
				case double doubleLeft when right is string strRight:
					{
						if (double.TryParse(strRight, out double doubleRight)) return doubleLeft == doubleRight;
					}
					break;
				case float floatLeft when right is string strRight:
					{
						if (float.TryParse(strRight, out float floatRight)) return floatLeft == floatRight;
					}
					break;
				case decimal decimalLeft when right is string strRight:
					{
						if (decimal.TryParse(strRight, out decimal decimalRight)) return decimalLeft == decimalRight;
					}
					break;
				case DateTime dateTimeLeft when right is DateTime dateTimeRight:
					return dateTimeLeft == dateTimeRight;
				case DateTime dateTimeLeft when right is string strRight:
					{
						if (DateTime.TryParse(strRight, out DateTime dateTimeRight)) return dateTimeLeft == dateTimeRight;
					}
					break;
			}
			return false;
		}

		public override bool Equals(object right)
		{
			return AreEqual(_value, right) || AreEqual(right, _value);
		}

		#endregion

		#region Math

		public static string DuplicateString(Any str, int duplicateFactor)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < duplicateFactor; i++)
			{
				sb.Append(str);
			}
			return sb.ToString();
		}

		public static double operator *(Any a, double b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl * b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal * b;
			if (a._value is float floatVal) return floatVal * b;
			if (a._value is double doubleVal) return doubleVal * b;
			if (a._value is long longVal) return longVal * b;
			if (a._value is int intVal) return intVal * b;
			throw new OverflowException();
		}

		public static double operator *(double a, Any b)
		{
			return b * a;
		}

		public static double operator *(Any a, decimal b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl * (double)b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal * (double)b;
			if (a._value is float floatVal) return floatVal * (double)b;
			if (a._value is double doubleVal) return doubleVal * (double)b;
			if (a._value is long longVal) return longVal * (double)b;
			if (a._value is int intVal) return intVal * (double)b;
			throw new OverflowException();
		}

		public static double operator *(decimal a, Any b)
		{
			return b * a;
		}

		public static double operator *(Any a, long b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl * b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal * b;
			if (a._value is float floatVal) return floatVal * b;
			if (a._value is double doubleVal) return doubleVal * b;
			if (a._value is long longVal) return longVal * b;
			if (a._value is int intVal) return intVal * b;
			throw new OverflowException();
		}

		public static double operator *(long a, Any b)
		{
			return b * a;
		}

		public static Any operator *(Any a, Any b)
		{
			if (a._value is string || b._value is string)
			{
				if (a._value is string valA && double.TryParse(valA, out double dblA)) return dblA * b;
				if (b._value is string valB && double.TryParse(valB, out double dblB)) return dblB * a;
				if (a._value is string && IsNumber(b._value) && b % 1.0 == 0) return DuplicateString(a, (int)(b._value));
				if (b._value is string && IsNumber(a._value) && a % 1.0 == 0) return DuplicateString(b, (int)(a._value));
			}
			if (a._value is decimal || b._value is decimal)
			{
				if (a._value is decimal valA) return valA * b;
				if (b._value is decimal valB) return a * valB;
			}
			if (a._value is double doubleVal || b._value is double)
			{
				if (a._value is double valA) return valA * b;
				if (b._value is double valB) return a * valB;
			}
			if (a._value is float floatVal || b._value is float)
			{
				if (a._value is float valA) return valA * b;
				if (b._value is float valB) return a * valB;
			}
			if (a._value is long longVal || b._value is long)
			{
				if (a._value is long valA) return valA * b;
				if (b._value is long valB) return a * valB;
			}
			if (a._value is int intVal || b._value is int)
			{
				if (a._value is int valA) return valA * b;
				if (b._value is int valB) return a * valB;
			}
			throw new OverflowException();
		}

		public static double operator +(Any a, double b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl + b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal + b;
			if (a._value is float floatVal) return floatVal + b;
			if (a._value is double doubleVal) return doubleVal + b;
			if (a._value is long longVal) return longVal + b;
			if (a._value is int intVal) return intVal + b;
			throw new OverflowException();
		}

		public static double operator +(double a, Any b)
		{
			return b + a;
		}

		public static double operator +(decimal a, Any b)
		{
			return b + a;
		}

		public static double operator +(Any a, decimal b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl + (double)b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal + (double)b;
			if (a._value is float floatVal) return floatVal + (double)b;
			if (a._value is double doubleVal) return doubleVal + (double)b;
			if (a._value is long longVal) return longVal + (double)b;
			if (a._value is int intVal) return intVal + (double)b;
			throw new OverflowException();
		}

		public static double operator +(long a, Any b)
		{
			return b + a;
		}

		public static double operator +(Any a, long b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl + b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal + b;
			if (a._value is float floatVal) return floatVal + (double)b;
			if (a._value is double doubleVal) return doubleVal + b;
			if (a._value is long longVal) return longVal + (double)b;
			if (a._value is int intVal) return intVal + (double)b;
			throw new OverflowException();
		}

		public static Any operator +(Any a, Any b)
		{
			if (a._value is string || b._value is string)
			{
				if (a._value is string valA)
				{
					if (double.TryParse(valA, out double dbl)) return dbl + b;
				}
				if (b._value is string valB)
				{
					if (double.TryParse(valB, out double dbl)) return dbl + a;
				}
				return a._value.ToString() + b._value.ToString();
			}
			if (a._value is decimal || b._value is decimal)
			{
				if (a._value is decimal valA) return valA + b;
				if (b._value is decimal valB) return a + valB;
			}
			if (a._value is double doubleVal || b._value is double)
			{
				if (a._value is double valA) return valA + b;
				if (b._value is double valB) return a + valB;
			}
			if (a._value is float floatVal || b._value is float)
			{
				if (a._value is float valA) return valA + b;
				if (b._value is float valB) return a + valB;
			}
			if (a._value is long longVal || b._value is long)
			{
				if (a._value is long valA) return valA + b;
				if (b._value is long valB) return a + valB;
			}
			if (a._value is int intVal || b._value is int)
			{
				if (a._value is int valA) return valA + b;
				if (b._value is int valB) return a + valB;
			}
			throw new OverflowException();
		}

		public static double operator /(Any a, double b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl / b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal / b;
			if (a._value is float floatVal) return floatVal / b;
			if (a._value is double doubleVal) return doubleVal / b;
			if (a._value is long longVal) return longVal / b;
			if (a._value is int intVal) return intVal / b;
			throw new OverflowException();
		}

		public static double operator /(double a, Any b)
		{
			if (b._value is string valB)
			{
				if (double.TryParse(valB, out double dbl)) return a / dbl;
			}

			if (b._value is decimal decimalVal) return (double)decimalVal / a;
			if (b._value is float floatVal) return floatVal / a;
			if (b._value is double doubleVal) return doubleVal / a;
			if (b._value is long longVal) return longVal / a;
			if (b._value is int intVal) return intVal / a;
			throw new OverflowException();
		}

		public static double operator /(Any a, long b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl / b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal / b;
			if (a._value is float floatVal) return floatVal / b;
			if (a._value is double doubleVal) return doubleVal / b;
			if (a._value is long longVal) return longVal / b;
			if (a._value is int intVal) return intVal / b;
			throw new OverflowException();
		}

		public static double operator /(long a, Any b)
		{
			if (b._value is string valB)
			{
				if (double.TryParse(valB, out double dbl)) return a / dbl;
			}

			if (b._value is decimal decimalVal) return (double)decimalVal / a;
			if (b._value is float floatVal) return floatVal / a;
			if (b._value is double doubleVal) return doubleVal / a;
			if (b._value is long longVal) return longVal / a;
			if (b._value is int intVal) return intVal / a;
			throw new OverflowException();
		}

		public static double operator /(Any a, decimal b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl / (double)b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal / (double)b;
			if (a._value is float floatVal) return floatVal / (double)b;
			if (a._value is double doubleVal) return doubleVal / (double)b;
			if (a._value is long longVal) return longVal / (double)b;
			if (a._value is int intVal) return intVal / (double)b;
			throw new OverflowException();
		}

		public static double operator /(decimal a, Any b)
		{
			if (b._value is string valB)
			{
				if (double.TryParse(valB, out double dbl)) return (double)a / dbl;
			}

			if (b._value is decimal decimalVal) return (double)decimalVal / (double)a;
			if (b._value is float floatVal) return floatVal / (double)a;
			if (b._value is double doubleVal) return doubleVal / (double)a;
			if (b._value is long longVal) return longVal / (double)a;
			if (b._value is int intVal) return intVal / (double)a;
			throw new OverflowException();
		}

		public static Any operator /(Any a, Any b)
		{
			if (a._value is string || b._value is string)
			{
				if (a._value is string valA)
				{
					if (double.TryParse(valA, out double dbl)) return dbl / b;
				}
				if (b._value is string valB)
				{
					if (double.TryParse(valB, out double dbl)) return dbl / a;
				}
			}
			if (a._value is decimal || b._value is decimal)
			{
				if (a._value is decimal valA) return valA / b;
				if (b._value is decimal valB) return a / valB;
			}
			if (a._value is double doubleVal || b._value is double)
			{
				if (a._value is double valA) return valA / b;
				if (b._value is double valB) return a / valB;
			}
			if (a._value is float floatVal || b._value is float)
			{
				if (a._value is float valA) return valA / b;
				if (b._value is float valB) return a / valB;
			}
			if (a._value is long longVal || b._value is long)
			{
				if (a._value is long valA) return valA / b;
				if (b._value is long valB) return a / valB;
			}
			if (a._value is int intVal || b._value is int)
			{
				if (a._value is int valA) return valA / b;
				if (b._value is int valB) return a / valB;
			}
			throw new OverflowException();
		}

		public static double operator -(Any a, double b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl - b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal - b;
			if (a._value is float floatVal) return floatVal - b;
			if (a._value is double doubleVal) return doubleVal - b;
			if (a._value is long longVal) return longVal - b;
			if (a._value is int intVal) return intVal - b;
			throw new OverflowException();
		}

		public static double operator -(double a, Any b)
		{
			return (b - a) * -1;
		}

		public static double operator -(Any a, decimal b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl - (double)b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal - (double)b;
			if (a._value is float floatVal) return floatVal - (double)b;
			if (a._value is double doubleVal) return doubleVal - (double)b;
			if (a._value is long longVal) return longVal - (double)b;
			if (a._value is int intVal) return intVal - (double)b;
			throw new OverflowException();
		}

		public static double operator -(decimal a, Any b)
		{
			return (b - a) * -1;
		}

		public static double operator -(Any a, long b)
		{
			if (a._value is string valA)
			{
				if (double.TryParse(valA, out double dbl)) return dbl - b;
			}

			if (a._value is decimal decimalVal) return (double)decimalVal - b;
			if (a._value is float floatVal) return floatVal - (double)b;
			if (a._value is double doubleVal) return doubleVal - b;
			if (a._value is long longVal) return longVal - (double)b;
			if (a._value is int intVal) return intVal - (double)b;
			throw new OverflowException();
		}

		public static double operator -(long a, Any b)
		{
			return (b - a) * -1;
		}

		public static Any operator -(Any a, Any b)
		{
			if (a._value is string || b._value is string)
			{
				if (a._value is string valA)
				{
					if (double.TryParse(valA, out double dbl)) return dbl - b;
				}
				if (b._value is string valB)
				{
					if (double.TryParse(valB, out double dbl)) return dbl - a;
				}
			}
			if (a._value is decimal || b._value is decimal)
			{
				if (a._value is decimal valA) return valA - b;
				if (b._value is decimal valB) return a - valB;
			}
			if (a._value is double doubleVal || b._value is double)
			{
				if (a._value is double valA) return valA - b;
				if (b._value is double valB) return a - valB;
			}
			if (a._value is float floatVal || b._value is float)
			{
				if (a._value is float valA) return valA - b;
				if (b._value is float valB) return a - valB;
			}
			if (a._value is long longVal || b._value is long)
			{
				if (a._value is long valA) return valA - b;
				if (b._value is long valB) return a - valB;
			}
			if (a._value is int intVal || b._value is int)
			{
				if (a._value is int valA) return valA - b;
				if (b._value is int valB) return a - valB;
			}
			throw new OverflowException();
		}

		public static double operator %(double a, Any b)
		{
			int div = (int)Math.Max(1, Math.Floor(a / b));
			return a - div * b;
		}

		public static double operator %(Any a, double b)
		{
			int div = (int)Math.Max(1, Math.Floor(a / b));
			return a - div * b;
		}

		public static decimal operator %(decimal a, Any b)
		{
			int div = (int)Math.Max(1, Math.Floor(a / b));
			return a - div * (decimal)(b * 1m);
		}

		public static decimal operator %(Any a, decimal b)
		{
			int div = (int)Math.Max(1, Math.Floor(a / b));
			return (decimal)(a * 1m) - div * b;
		}

		public static long operator %(long a, Any b)
		{
			int div = (int)Math.Max(1, Math.Floor(a / b));
			return a - div * (long)(b * 1m);
		}

		public static long operator %(Any a, long b)
		{
			int div = (int)Math.Max(1, Math.Floor(a / b));
			return (long)(a * 1m) - div * b;
		}

		public static Any operator %(Any a, Any b)
		{
			if (a._value is string || b._value is string)
			{
				if (a._value is string valA && double.TryParse(valA, out double dblA)) return dblA % b;
				if (b._value is string valB && double.TryParse(valB, out double dblB)) return dblB % a;
			}
			if (a._value is decimal || b._value is decimal)
			{
				if (a._value is decimal valA) return valA % b;
				if (b._value is decimal valB) return a % valB;
			}
			if (a._value is double doubleVal || b._value is double)
			{
				if (a._value is double valA) return valA % b;
				if (b._value is double valB) return a % valB;
			}
			if (a._value is float floatVal || b._value is float)
			{
				if (a._value is float valA) return valA % b;
				if (b._value is float valB) return a % valB;
			}
			if (a._value is long longVal || b._value is long)
			{
				if (a._value is long valA) return valA % b;
				if (b._value is long valB) return a % valB;
			}
			if (a._value is int intVal || b._value is int)
			{
				if (a._value is int valA) return valA % b;
				if (b._value is int valB) return a % valB;
			}
			throw new OverflowException();
		}

		#endregion

		public override string ToString()
		{
			return _value.ToString();
		}

		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}
	}
}
