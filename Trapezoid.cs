using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Trapezoid : IShape
    {
        private double _firstside;
        private double _secondside;
        private double _firstbase;
        private double _secondbase;
        private double _height;


        public Trapezoid(int numOfSides,double firstSide, double secondSide, double firstBase, 
                        double secondBase, double height) : base(numOfSides) 
        {
            _firstside = firstSide;
            _secondside = secondSide;
            _firstbase = firstBase;
            _secondbase = secondBase;
            _height = height;
        }

        public double Perimeter()
        {
            _perimeter = _firstside + _secondside + _firstbase + _secondbase;
            return _perimeter;
        }
        public double Area()
        {
            _Area = (_firstbase + _secondbase) * _height / 2;
            return _Area;
        }


    }
}
