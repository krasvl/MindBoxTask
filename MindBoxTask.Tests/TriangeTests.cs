using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MindBoxTask.Tests
{
    public class TriangeTests
    {
        [Fact]
        public void GetSquare_Side1Is3_Side2Is4_Side1Is5()
        {
            //arrange
            var side1 = 3;
            var side2 = 4;
            var side3 = 5;
            var circle = new Triangle(side1, side2, side3);

            //act
            var square = circle.GetSquare();

            //assert
            Assert.Equal(6, square);
        }

        [Fact]
        public void TriangleIsRectangular_Side1Is3_Side2Is4_Side1Is5()
        {
            //arrange
            var side1 = 3;
            var side2 = 4;
            var side3 = 5;
            var circle = new Triangle(side1, side2, side3);

            //act
            var result = circle.TriangleIsRectangular();

            //assert
            Assert.True(result);
        }

        [Fact]
        public void TriangleIsRectangular_Side1Is4_Side2Is3_Side1Is5()
        {
            //arrange
            var side1 = 4;
            var side2 = 3;
            var side3 = 5;
            var circle = new Triangle(side1, side2, side3);

            //act
            var result = circle.TriangleIsRectangular();

            //assert
            Assert.True(result);
        }

        [Fact]
        public void TriangleIsRectangular_Side1Is5_Side2Is4_Side1Is3()
        {
            //arrange
            var side1 = 5;
            var side2 = 4;
            var side3 = 3;
            var circle = new Triangle(side1, side2, side3);

            //act
            var result = circle.TriangleIsRectangular();

            //assert
            Assert.True(result);
        }

        [Fact]
        public void TriangleIsRectangular_Side1Is3_Side2Is3_Side1Is3()
        {
            //arrange
            var side1 = 3;
            var side2 = 3;
            var side3 = 3;
            var circle = new Triangle(side1, side2, side3);

            //act
            var result = circle.TriangleIsRectangular();

            //assert
            Assert.False(result);
        }
    }
}
