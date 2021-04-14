using System;
using Xunit;

namespace Zadanie2_Vector.Tests
{
    public class UnitTest1
    {


        [Fact]

        public void LengthTest()
        {
            var vector1 = new Vector(5, 6, 7);
            // Vector b = new Vector(8, 9, 1);

            double resultLength = vector1.Length();
            Assert.Equal(10.488, resultLength, 3);

            //double resultScal = a.ScalarMultiplication();
            // Assert.Equal(101, resultScal, 3);
        }

        [Fact]
        public void ScalTest()
        {
            var vector1 = new Vector(5, 6, 7);
            var vector2 = new Vector(8, 9, 1);

            double resultScal = vector1.ScalarMultiplication(vector2);
            Assert.Equal(101, resultScal, 1);
        }


        [Fact]
        public static void VectorMult()
        {
            var vector1 = new Vector(5.0, 6.0, 7.0);
            var vector2 = new Vector(8.0, 9.0, 1.0);

            Vector resultVect = vector1.VectorMultiplication(vector2);

            Assert.Equal(new Vector(-57.0, 51.0, -3.0), resultVect);
        }

        [Fact]
        public void Angle()
        {
            var vector1 = new Vector(5, 6, 7);
            var vector2 = new Vector(8, 9, 1);

            var resultAngle = vector1.Angle(vector2);
            Assert.Equal(0.79698, resultAngle, 5);
        }

        [Fact]
        public void Sum()
        {
            var vector1 = new Vector(5.0, 6.0, 7.0);
            var vector2 = new Vector(8.0, 9.0, 1.0);

            var resultSum = vector1.Sum(vector2);

            Assert.Equal(new Vector(13.0, 15.0, 8.0), resultSum);
        }

        [Fact]
        public void Dif()
        {
            var vector1 = new Vector(5.0, 6.0, 7.0);
            var vector2 = new Vector(8.0, 9.0, 1.0);

            Vector resultDif = vector1.Difference(vector2);

            Assert.Equal(new Vector(-3.0, -3.0, 6.0), resultDif);
        }
    }
}

