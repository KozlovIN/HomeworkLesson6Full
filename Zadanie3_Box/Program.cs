using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_Box
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Box container = new Box(40);
                var shapes = new List<Shape>();

                Box box = new Box(20);
                shapes.Add(box);

                Cylinder cylinder = new Cylinder(30, 10);
                shapes.Add(cylinder);

                Pyramid pyramid = new Pyramid(3200, 10);
                shapes.Add(pyramid);

                Ball ball = new Ball(15);
                shapes.Add(ball);

                Ball ball1 = new Ball(10);
                shapes.Add(ball1);

                Console.WriteLine($"Объём контейнера: {container.Volume()}");

                foreach (var shap in shapes)
                {
                    if (!container.Add(shap))
                    {
                        Console.WriteLine("Контейнер заполнен!\nВ контейнере находятся фигуры:\n");
                        foreach (var shp in container.Shapes)
                        {
                            Console.WriteLine($"{shp.Name} объёмом {shp.Volume()}");
                        }
                        break;
                    }

                    Console.WriteLine($"В контейнер добавлена фигура {shap.Name}" +
                            $"\nОставшийся объём {container.RemainingVolume()}");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Произошла трагическая ошибка: {ex.Message}");
            }

        }
    }
}
