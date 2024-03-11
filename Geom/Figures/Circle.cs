using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Figures
{
    public class Circle : Figure
    {
        public float radius { get; set; }

        public Circle(float radius) =>
            this.radius = radius;

        public override double Area
        {
            get => Math.PI * Math.Pow(radius, 2);
        }
    }
}
