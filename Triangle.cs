using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Triangle : IShape
    {
        private double _firstside;
        private double _secondside;
        private double _base;
        private double _height;
        public Triangle(int numOfSides,double firstSide, double secondSide, double Base, double height) : base(numOfSides)
        {
            _firstside = firstSide;
            _secondside = secondSide;
            _base = Base;
            _height = height;
        }

        public double Perimeter()
        {
            _perimeter = _firstside + _secondside + _base;
            return _perimeter;
        }
        public double Area()
        {
            _Area = _height * _base / 2;
            return _Area;
        }
    }
}
