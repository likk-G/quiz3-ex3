using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Rectangle : IShape
    {
        private readonly double _firstSide;
        private readonly double _secondSide;

        public Rectangle(int numOfSides, double firstSide, double secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
        }

        public double Perimeter()
        {
            _perimeter = (_firstSide + _secondSide) * 2;
            return _perimeter;
        }

        public double Area()
        {
            _Area = _firstSide * _secondSide;
            return _Area;
        }
    }
}
