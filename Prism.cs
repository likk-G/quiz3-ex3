using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Prism : IShape
    {
        private double _length;
        private double _width;
        private double _height;

        public Prism(int numOfSides, double length, double width, double height) : base(numOfSides)
        {
            _length = length;
            _width = width;
            _height = height;
        }
        public double SurfaceArea()
        {
            _Area = (_length * _width + _width * _height + _height * _length) * 2;
            return _Area;
        }
        public double Volume()
        {
            return _length * _width * _height;
        }

    }
}
