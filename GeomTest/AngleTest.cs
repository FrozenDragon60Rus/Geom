using Xunit;
using Geom;

namespace GeomTest
{
    public class AngleTest
    {
        [Fact]
        public void Get_Angle_Test()
        {
            var angle = Angle.Get(5, 4, 3);

            Assert.True(angle == Math.PI / 2);
        }
        [Fact]
        public void Convert_Radians_To_Degree_Test()
        {
            var angle = Angle.Get(5, 4, 3);
            angle = Angle.RadiansToDegrees(angle);

            Assert.True(angle == 90d);
        }
    }
}
