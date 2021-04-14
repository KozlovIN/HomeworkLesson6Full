using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadanie2_Vector
{
	class Program

	{
		static void Main()
		{
			try
			{
				var vector1 = new Vector(5, 6, 7);
				var vector2 = new Vector(8, 9, 1);

				Console.WriteLine($"Длина: {vector1.Length()}.");
				Console.WriteLine($"Скалярное произведение: {vector1.ScalarMultiplication(vector2)}.");
				Console.WriteLine($"Векторное произведение: {vector1.VectorMultiplication(vector2)}.");
				Console.WriteLine($"Угол: {vector1.Angle(vector2)}.");
				Console.WriteLine($"Сумма: {vector1.Sum(vector2)}.");
				Console.WriteLine($"Разность: {vector1.Difference(vector2)}.");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Произошла непоправимая ошибка: {ex.Message}");
			}


			Console.ReadKey();
		}
	}
}

