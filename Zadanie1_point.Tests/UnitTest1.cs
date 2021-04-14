using System;
using Xunit;

namespace Zadanie1_point.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Polygon()
        {

            Point ps1 = new Point("A", 0, 0);
            Point ps2 = new Point("B", 0, 3);
            Point ps3 = new Point("C", 1, 4);
            Point ps4 = new Point("D", 3, 3);
            Point ps5 = new Point("E", 3, 0);

            Polygon triangle = new Polygon(ps1, ps2, ps3);
            Polygon quadrangle = new Polygon(ps1, ps2, ps3, ps4);
            Polygon pentagon = new Polygon(ps1, ps2, ps3, ps4, ps5);

            double perimeter3 = triangle.Perimeter();
            double perimeter4 = quadrangle.Perimeter();
            double perimeter5 = pentagon.Perimeter();



            Assert.Equal(8.537, perimeter3, 3);
            Assert.Equal(10.893, perimeter4, 3);
            Assert.Equal(12.650, perimeter5, 3);

        }

        [Fact]

        public void PolygonDistanse2D()
        {
            Point ps1 = new Point("A", 0, 0);
            Point ps2 = new Point("B", 0, 3);

            var sid1 = new Polygon(ps1, ps2);
            double side1 = sid1.Distanse2D(ps1, ps2);
            Assert.Equal(3, side1, 1);


        }


    }
}
