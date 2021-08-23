using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTask
{
    public class Triangle : IFigure
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double GetSquare() =>
            Math.Sqrt(
                (_side1 + _side2 + _side3) *
                (_side1 - _side2 + _side3) *
                (_side1 + _side2 - _side3) *
                (_side2 - _side1 + _side3) / 16
                );

        public bool TriangleIsRectangular() =>
            (_side1 * _side1 == _side2 * _side2 + _side3 * _side3) ||
            (_side2 * _side2 == _side1 * _side1 + _side3 * _side3) ||
            (_side3 * _side3 == _side1 * _side1 + _side2 * _side2);
    }
}
