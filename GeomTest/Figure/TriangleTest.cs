using Geom.Figures;

namespace GeomTest.Figure
{
    public class TriangleTest
    {
        [Fact]
        public void Get_Triangle_Square_Test()
        {
            var figure = new Triangle(4, 3, 5);

            var square = figure.Square;
            double testSquare = 6;
            Assert.True(square == testSquare);
        }
        [Fact]
        public void Triangle_Is_Right()
        {
            var figure = new Triangle(4, 3, 5);

            Assert.True(figure.isRight);
        }
    }
}
