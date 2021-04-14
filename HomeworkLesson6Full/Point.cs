using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_point
{
    public class Point
    {
        public string Name { get; init; }
        public int X { get; init; }
        public int Y { get; init; }

        public Point(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }


    }
}
