using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_Vector
{
	public class Vector
	{
		public double X;
		public double Y;
		public double Z;


		public Vector(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}





		public double Length()
		{
			return Math.Sqrt(
				X * X +
				Y * Y +
				Z * Z);
		}



		public double ScalarMultiplication(Vector other)
		{
			return
				X * other.X +
				Y * other.Y +
				Z * other.Z;
		}



		public Vector VectorMultiplication(Vector other)
		{

			return new Vector(
				Y * other.Z - Z * other.Y,
				Z * other.X - X * other.Z,
				X * other.Y - Y * other.X);

		}

		public double Angle(Vector other)
		{
			double length = Length();
			double otherLength = other.Length();
			if (length == 0 || otherLength == 0)
			{
				Console.WriteLine("Ошибка\nНевозможно получить угол для нулевого вектора");
				return default;
			}

			return ScalarMultiplication(other) / (length * otherLength);
		}

		public Vector Sum(Vector other)
		{
			return new Vector(
				X + other.X,
				Y + other.Y,
				Z + other.Z);
		}

		public Vector Difference(Vector other)
		{
			return new Vector(
				X - other.X,
				Y - other.Y,
				Z - other.Z);
		}

		public override string ToString()
		{
			return $"(Vector  {{{X}, {Y}, {Z}}})";
		}
	}
}

