using System;
using Xunit;

namespace Zadanie3_Box.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void BoxVolumeTest()
        {
            Box box = new Box(10);
            double result = box.Volume();
            Assert.Equal(1000.0, result, 5);
        }

        [Fact]
        public void BallVolumeTest()
        {
            var ball = new Ball(15.0);

            double vol = ball.Volume();

            Assert.Equal(14137.167, vol, 3);
        }

        [Fact]
        public void CylinderVolumeTest()
        {
            var cylinder = new Cylinder(30.0, 10.0);

            double vol = cylinder.Volume();

            Assert.Equal(28274.334, vol, 3);
        }

        [Fact]
        public void PyramidVolumeTest()
        {
            var pyramid = new Pyramid(3200.0, 10.0);

            double vol = pyramid.Volume();

            Assert.Equal(10666.667, vol, 3);
        }

        [Theory]
        [InlineData(20, 3200, 10)]
        public void TestShapeAddition(double containerHeight, double pyramidS, double pyramidH)
        {
            var box = new Box(containerHeight);
            var pyramid = new Pyramid(pyramidS, pyramidH);

            Assert.False(box.Add(pyramid));
        }
    }
}
