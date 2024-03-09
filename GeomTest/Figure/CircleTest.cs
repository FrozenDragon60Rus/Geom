using Geom.Figures;

namespace GeomTest.Figure
{
    public class CircleTest
    {
        [Fact]
        public void Get_Circle_Square_Test()
        {
            var figure = new Circle(5);

            var square = figure.Square;
            double test = 25;
            Assert.True(square / Math.PI == test);
        }
    }
}
