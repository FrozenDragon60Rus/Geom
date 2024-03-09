using Geom.Figures;

namespace GeomTest.Figure
{
    public class FigureTest
    {
        [Fact]
        public void Get_Square_From_Figure()
        {
            Geom.Figures.Figure figure = new Triangle(4, 3, 5);

            var square = figure.Square;
            double testSquare = 6;
            Assert.True(square == testSquare);
        }
    }
}
