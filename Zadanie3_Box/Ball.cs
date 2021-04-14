using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_Box
{
    public class Ball : Shape
    {
        public double Radius { get; }
        public Ball(double r)
        {
            Radius = r;
        }

        public override string Name => "Шар";


        public override double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);

        }
    }
}
