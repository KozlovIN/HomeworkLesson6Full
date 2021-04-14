using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_Box
{
    public class Box : Shape
    {

        public double Height { get; }

        public Box(double height)
        {
            Height = height;
        }

        public override string Name => "Куб";


        private double _filledVolume;

        public List<Shape> Shapes { get; } = new List<Shape>();

        public double RemainingVolume()
        {
            return Volume() - _filledVolume;
        }

        public bool Add(Shape shape)
        {
            double remainingVolume = RemainingVolume();
            double shapeVolume = shape.Volume();

            if (remainingVolume >= shapeVolume)
            {
                Shapes.Add(shape);
                _filledVolume += shapeVolume;

                return true;
            }
            else
            {
                return false;
            }
        }

        public override double Volume()
        {
            return Math.Pow(Height, 3);
        }



    }
}

