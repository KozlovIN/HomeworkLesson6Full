using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_point
{
    public class Polygon
    {

        private List<Point> _points;
      //  private Point s1;
        //private Point s2;

        public string Name { get; }


        public Polygon(Point ps1, Point ps2, Point ps3)
        {
            _points = new List<Point> { ps1, ps2, ps3 };
            Name = "Триугольник";
        }

        public Polygon(Point ps1, Point ps2, Point ps3, Point ps4)
        {
            _points = new List<Point> { ps1, ps2, ps3, ps4 };
            Name = "Четырехугольник";
        }

        public Polygon(Point ps1, Point ps2, Point ps3, Point ps4, Point ps5)
        {
            _points = new List<Point> { ps1, ps2, ps3, ps4, ps5 };
            Name = "Пятиугольник";
        }

        public Polygon(Point s1, Point s2)
        {
        }


        public double Perimeter()
        {

            int lastI = _points.Count - 1;
            double perimeter = 0.0;
            for (int i = 0; i < _points.Count; ++i)
            {
                int nextI = i == lastI ? 0 : i + 1;
                perimeter += Distanse2D(_points[i], _points[nextI]);
            }
            return perimeter;
        }

        public override string ToString()
        {
            return $"{Name} с периметром {Perimeter()}.";
        }

        public double Distanse2D(Point ps1, Point ps2)
        {
            return Math.Sqrt(Math.Pow(ps2.X - ps1.X, 2) + Math.Pow(ps2.Y - ps1.Y, 2));
        }


    }
}
