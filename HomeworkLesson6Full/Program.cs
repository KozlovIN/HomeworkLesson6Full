using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadanie1_point
{
    class Program
    {
        public static void Main(string[] arg)
        {
            try
            {

                Console.Write("Ведите значение Х1: ");
                string x1 = Console.ReadLine();

                Console.Write("Ведите значение Y1: ");
                string y1 = Console.ReadLine();

                var ps1 = new Point("А", int.Parse(x1), int.Parse(y1));
                Console.WriteLine($"Точка:{ps1.Name}  X={ps1.X} Y={ps1.Y}");
                string s1 = string.Empty;
                Console.WriteLine(s1);


                Console.Write("Ведите значение Х2: ");
                string x2 = Console.ReadLine();
                Console.Write("Ведите значение Y2: ");
                string y2 = Console.ReadLine();
                var ps2 = new Point("B", int.Parse(x2), int.Parse(y2));
                Console.WriteLine($"Точка:{ps2.Name}  X={ps2.X} Y={ps2.Y}");
                Console.WriteLine(s1);

                Console.Write("Ведите значение Х3: ");
                string x3 = Console.ReadLine();
                Console.Write("Ведите значение Y3: ");
                string y3 = Console.ReadLine();
                var ps3 = new Point("C", int.Parse(x3), int.Parse(y3));
                Console.WriteLine($"Точка:{ps3.Name}  X={ps3.X} Y={ps3.Y}");
                Console.WriteLine(s1);

                Console.Write("Ведите значение Х4: ");
                string x4 = Console.ReadLine();
                Console.Write("Ведите значение Y4: ");
                string y4 = Console.ReadLine();
                var ps4 = new Point("D", int.Parse(x4), int.Parse(y4));
                Console.WriteLine($"Точка:{ps4.Name}  X={ps4.X} Y={ps4.Y}");
                Console.WriteLine(s1);

                Console.Write("Ведите значение Х5: ");
                string x5 = Console.ReadLine();
                Console.Write("Ведите значение Y5: ");
                string y5 = Console.ReadLine();
                var ps5 = new Point("E", int.Parse(x5), int.Parse(y5));
                Console.WriteLine($"Точка:{ps5.Name}  X={ps5.X} Y={ps5.Y}");
                Console.WriteLine(s1);


                var triangle = new Polygon(ps1, ps2, ps3);

                var quadrangle = new Polygon(ps1, ps2, ps3, ps4);

                var pentagon = new Polygon(ps1, ps2, ps3, ps4, ps5);

                Console.WriteLine("Расчет периметра многоугольников:");

                ShowPolygonInfo(triangle);
                ShowPolygonInfo(quadrangle);
                ShowPolygonInfo(pentagon);

                Console.ReadKey();


            }

            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непоправимая ошибка: {ex.Message}\n {ex.StackTrace}");
            }
        }
        private static void ShowPolygonInfo(Polygon polygon)
        {
            if (polygon == null)
            {
                throw new ArgumentNullException(nameof(polygon));
            }

            double perimeter = polygon.Perimeter();

            Console.WriteLine($"Perimeter of {polygon.Name}: {perimeter}");
        }


    }
}
