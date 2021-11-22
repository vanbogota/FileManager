using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5
{
    public class RationalNumber
    {
        private int _numerator, _denominator;

        public RationalNumber(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public int Numerator
        {
            get 
            { 
                return _numerator; 
            }
            set 
            { 
                _numerator = value; 
            }
        }
        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                _denominator = value;
            }
        }

        public float Result
        {
            get { return (float)Numerator / (float)Denominator; }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as RationalNumber);
        }

        public bool Equals(RationalNumber rationalNumber)
        {
            return Numerator == rationalNumber.Numerator && Denominator == rationalNumber.Denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static bool operator == (RationalNumber first, RationalNumber second)
        {
            return (first.Result == second.Result);
        }

        public static bool operator !=(RationalNumber first, RationalNumber second)
        {
            return (first.Result != second.Result);
        }
        public static bool operator <(RationalNumber first, RationalNumber second)
        {
            return (first.Numerator * second.Denominator < first.Denominator * second.Numerator);
        }
        public static bool operator >(RationalNumber first, RationalNumber second)
        {
            return (first.Numerator * second.Denominator > first.Denominator * second.Numerator);
        }
        public static bool operator <=(RationalNumber first, RationalNumber second)
        {
            return (first.Numerator * second.Denominator <= first.Denominator * second.Numerator);
        }
        public static bool operator >=(RationalNumber first, RationalNumber second)
        {
            return (first.Numerator * second.Denominator >= first.Denominator * second.Numerator);
        }

        public static RationalNumber operator +(RationalNumber first, RationalNumber second)
        {
            return new RationalNumber(first.Numerator * second.Denominator + second.Numerator * first.Denominator, first.Denominator*second.Denominator);
        }

        public static RationalNumber operator -(RationalNumber first, RationalNumber second)
        {
            return new RationalNumber(first.Numerator * second.Denominator - second.Numerator * first.Denominator, first.Denominator * second.Denominator);
        }
        public static RationalNumber operator -(RationalNumber rationalNumber)
        {
            
            return new RationalNumber(-rationalNumber.Numerator, rationalNumber.Denominator);
        }

        public static RationalNumber operator ++(RationalNumber rationalNamber)
        {
            rationalNamber.Numerator += rationalNamber.Denominator;
            
            return rationalNamber;
        }
        public static RationalNumber operator --(RationalNumber rationalNamber)
        {
            rationalNamber.Numerator -= rationalNamber.Denominator;

            return rationalNamber;
        }
        public static RationalNumber operator *(RationalNumber rationalNumber, int scale)
        {
            rationalNumber.Numerator *= scale; 
            return rationalNumber;
        }

        public static RationalNumber operator *(int scale, RationalNumber rationalNumber)
        {
            rationalNumber.Numerator *= scale;
            return rationalNumber;
        }
        public static RationalNumber operator /(RationalNumber rationalNumber, int scale)
        {
            rationalNumber.Denominator *= scale;
            return rationalNumber;
        }
        public static RationalNumber operator /(int scale, RationalNumber rationalNumber)
        {
            int temp = rationalNumber.Numerator;
            rationalNumber.Numerator = rationalNumber.Denominator*scale;
            rationalNumber.Denominator = temp;
            return rationalNumber;
        }

        public static float operator %(RationalNumber rationalNumber, int scale)
        {
            return rationalNumber.Result % scale;
        }
        //неявное преобразование
        public static implicit operator decimal(RationalNumber rationalNumber)
        {
            return (decimal)rationalNumber.Result;
        }
        //явное преобразование
        public static explicit operator float(RationalNumber rationalNumber)
        {
            return rationalNumber.Result;
        }
        public static explicit operator int(RationalNumber rationalNumber)
        {
            return (int)rationalNumber.Result;
        }
    }
}
