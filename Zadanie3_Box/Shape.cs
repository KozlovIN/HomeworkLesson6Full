using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_Box
{
    public abstract class Shape
    {
        // public abstract double volume { get; set; }
        public abstract string Name { get; }
        public abstract double Volume();

    }
}
