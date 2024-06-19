using Geom.Figures;

namespace GeomTest.Figures
{
    public class FigureTest
    {
        [Fact]
        public void GetAreaFromFigureTest()
        {
            Figure[] figure = 
            [
                new Triangle(4, 3, 5), 
                new Circle(5)
            ];

            double[] result = 
            [
                6, 
                78.54d    
            ];

            bool equal = true;
            int index = 0;
            double 
                currentResult,
                area;
			foreach (var f in figure)
            {
                currentResult = result[index++];
                area = Math.Round(f.Area, 2);
				equal &= area.Equals(currentResult);
			}

            Assert.True(equal);
        }
    }
}
