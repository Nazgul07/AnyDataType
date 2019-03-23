using System;

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
			if(IsNumber(left) && IsNumber(right))
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

		public static Any operator *(Any a, Any b)
		{
			if(a._value is string || b._value is string)
			{
				if(a._value is string valA)
				{
					if (double.TryParse(valA, out double dbl)) return dbl * b;
				}
				if (b._value is string valB)
				{
					if (double.TryParse(valB, out double dbl)) return dbl * a;
				}
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
