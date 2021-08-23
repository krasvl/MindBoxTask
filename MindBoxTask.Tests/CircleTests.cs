using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MindBoxTask;

namespace MindBoxTask.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetSquare_RadiusIs1()
        {
            //arrange
            var radius = 1;
            var circle = new Circle(radius);

            //act
            var square = circle.GetSquare();

            //assert
            Assert.Equal(Math.PI, square);
        }
    }
}
