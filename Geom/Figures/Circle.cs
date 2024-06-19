using System;

namespace Geom.Figures
{
    public class Circle(float radius) : Figure()
    {
        public float Radius { get; } = radius;

        public override double Area =>
            Math.PI * Math.Pow(Radius, 2);

		protected override void RightForm()
		{
			bool right = Radius > 0;

			if (!right)
				throw new Exception("This is not a circle");
		}
	}
}
