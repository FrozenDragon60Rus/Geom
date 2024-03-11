using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Figures
{
    public class Triangle : Figure
    {
        public float AB { get; set; }
        public float BC { get; set; }
        public float CA { get; set; }

        public Triangle(float A, float B, float C)
        {
            AB = A;
            BC = B;
            CA = C;
        }

        public override double Area
        {
            get => 0.5f * AB * BC * Math.Sin(Angle.Get(CA, AB, BC));
        }

        public bool isRight =>
            Angle.RadiansToDegrees(Angle.Get(AB, CA, BC)) == 90d ||
            Angle.RadiansToDegrees(Angle.Get(CA, BC, AB)) == 90d ||
            Angle.RadiansToDegrees(Angle.Get(BC, AB, CA)) == 90d;
    }
}
