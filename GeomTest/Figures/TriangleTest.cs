using Geom.Figures;
using Xunit;
using Xunit.Abstractions;

namespace GeomTest.Figures
{
    public class TriangleTest
    {
		private ITestOutputHelper Output { get; }

		public TriangleTest(ITestOutputHelper output) =>
			Output = output;

        [Theory
            , InlineData(4, 3, 5, 6)
            , InlineData(6, 3, 5, 7.48d)
			, InlineData(6, 3.5f, 5, 8.74d)]
        public void TriangleAreaTest(float a, float b, float c, double area)
        {
			var figure = new Triangle(a, b, c);
            var actualArea = Math.Round(figure.Area, 2);

			Assert.Equal(expected: area, actualArea);
        }
		[Theory
			, InlineData(4, 3, 5, 6)
            , InlineData(6, 3, 5, 7)
			, InlineData(6, 3.5f, 5, 7.25d)]
		public void TriangleSemiperimeterTest(float a, float b, float c, double semiperimeter)
        {
            var figure = new Triangle(a, b, c);
			var actualSemiperimeter = Math.Round(figure.Semiperimeter, 2);

			Assert.Equal(semiperimeter, actualSemiperimeter);
        }
		[Theory
			, InlineData(4, 3, 5)]
		public void TriangleRightTest(float a, float b, float c)
		{
			var figure = new Triangle(a, b, c);

			Assert.True(figure.IsRight);
		}
		[Theory
			, InlineData(3, 3, 5)]
		public void TriangleIsNotRightTest(float a, float b, float c)
		{
			var figure = new Triangle(a, b, c);

			Assert.False(figure.IsRight);
		}
		[Theory
			, InlineData(8, 3, 5)
			, InlineData(-4, 3, 5)
			, InlineData(4, -3, 5)
			, InlineData(4, 3, -5)
			, InlineData(4, 0, 5)]
		public void CheckFormExceptionTest(float a, float b, float c)
		{
			var createTriangle = () => new Triangle(a, b, c);

			Assert.Throws<Exception>(createTriangle);
		}
		[Fact]
		public void CheckFormTest()
		{
			var figure = new Triangle(4, 3, 5);

			Assert.NotNull(figure);
		}
	}
}
