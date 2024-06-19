using System;

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

        public bool IsRight =>
            A * A + B * B == C * C;
        
        protected override void RightForm()
        {
            bool right = A + B > C
                      && A + C > B
                      && B + C > A;

            if (!right)
                throw new Exception("This is not a triangle");
        }
	}
}
