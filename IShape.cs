using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class IShape
    {
        protected int _numOfSides;
        protected double _perimeter;
        protected double _Area;

        public IShape() { }
        public IShape(int numOfSides) 
        {
            _numOfSides = numOfSides;
        }
        public double Perimeter()
        {
            return _perimeter;
        }

        public double Area() 
        {
            return _Area;
        }

        public int GetNumOfSides()
        {
            return _numOfSides;
        }
    }
}
