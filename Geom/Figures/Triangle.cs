using System;
using System.Linq;

namespace Geom.Figures
{
    public class Triangle(float a, float b, float c) : Figure()
    {
        public float A { get; } = a;
        public float B { get; } = b;
        public float C { get; } = c;

        public override double Area =>
            Math.Sqrt(Semiperimeter * (Semiperimeter - A) * (Semiperimeter - B) * (Semiperimeter - C));

        public float Semiperimeter =>
            (A + B + C) / 2; 

        public bool IsRight 
        {
            get 
            {
                float[] point = [A, B, C];
                point = [.. point.OrderBy(x => x)];

                var powA = point.First() * point.First();
				var powB = point[1] * point[1];
				var powC = point.Last() * point.Last();

				return powA + powB == powC;
            }
        }
        
        protected override void RightForm()
        {
            bool right = A + B > C
                      && A + C > B
                      && B + C > A;

            right &= A > 0
                && B > 0
                && C > 0;

            if (!right)
                throw new Exception("This is not a triangle");
        }
	}
}
