using System;

namespace Geom.Figures
{
	public static class TriangleExtension
	{
		public static double GetAngle(this Triangle figure, string pointName)
		{
			double
				powA = Math.Pow(figure.A, 2),
				powB = Math.Pow(figure.B, 2),
				powC = Math.Pow(figure.C, 2);

			float isSame(float x) => nameof(x) == pointName ? 1 : x;

			double
				numerator,
				denominator;

			if (nameof(figure.A) == pointName)
			{
				numerator = powB + powC - powA;
				denominator = 2 * figure.B * figure.C;
			}
			else if(nameof(figure.B) == pointName)
			{
				numerator = powA + powC - powB;
				denominator = 2 * figure.A * figure.C;
			}
			else 
			{
				numerator = powA + powB - powC;
				denominator = 2 * figure.A * figure.B;
			}

			return Math.Acos(numerator / denominator) * 180 / Math.PI;
		}
	}
}
