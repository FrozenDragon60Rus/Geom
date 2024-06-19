using Geom.Figures;

namespace GeomTest.Figures
{
    public class CircleTest
    {
        [Theory
            , InlineData(5, 78.54d)
            , InlineData(7, 153.94d)]
        public void CircleAreaTest(float radius, double expetedArea)
        {
            var figure = new Circle(radius);

            var square = Math.Round(figure.Area, 2);
            Assert.Equal(expetedArea, square);
        }
		[Fact]
		public void CheckFormExceptionTest()
		{
			var createTriangle = () => new Triangle(8, 3, 5);

			Assert.Throws<Exception>(createTriangle);
		}
		[Fact]
		public void CheckFormTest()
		{
			var figure = new Circle(5);

			Assert.NotNull(figure);
		}
	}
}
