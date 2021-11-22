using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5
{
    public class ComplexNumber
    {
        private int _realPart, _imaginaryPart;

        public ComplexNumber(int realPart, int imaginaryPart)
        {
            _realPart = realPart;
            _imaginaryPart = imaginaryPart;
        }

        public int RealPart
        {
            get
            {
                return _realPart;
            }
            set
            {
                _realPart = value;
            }
        }
        public int ImaginaryPart
        {
            get
            {
                return _imaginaryPart;
            }
            set
            {
                _imaginaryPart = value;
            }
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as ComplexNumber);
        }

        public bool Equals(ComplexNumber complexNumber)
        {
            return RealPart == complexNumber.RealPart && ImaginaryPart == complexNumber.ImaginaryPart;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RealPart, ImaginaryPart);
        }
        public override string ToString()
        {
            return $"{RealPart} + {ImaginaryPart}i";
        }

        public static ComplexNumber operator +(ComplexNumber first, ComplexNumber second)
        {
            return new ComplexNumber(first.RealPart + second.RealPart, first.ImaginaryPart + second.ImaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber first, ComplexNumber second)
        {
            return new ComplexNumber(first.RealPart - second.RealPart, first.ImaginaryPart - second.ImaginaryPart);
        }

        public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second)
        {
            return new ComplexNumber(
                first.RealPart*second.RealPart - first.ImaginaryPart*second.ImaginaryPart,
                first.ImaginaryPart*second.RealPart + first.RealPart*second.ImaginaryPart
                );
        }
        public static bool operator ==(ComplexNumber first, ComplexNumber second)
        {
            return first.RealPart == second.RealPart && first.ImaginaryPart == second.ImaginaryPart;
        }

        public static bool operator !=(ComplexNumber first, ComplexNumber second)
        {
            return first.RealPart != second.RealPart || first.ImaginaryPart != second.ImaginaryPart;
        }
    }
}
