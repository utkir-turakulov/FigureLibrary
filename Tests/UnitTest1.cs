using AreaSolverLibrary;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsTriangleRectangular()
        {
			Triangle triangle = new Triangle(3,4,5);
			Assert.True(triangle.IsRectangular());
        }

		[Fact]
		public void CheckCircleArea()
		{
			Circle circle = new Circle(2);

			Assert.Equal(12.566, Math.Round(circle.GetArea(),3));
		}


		[Fact]
		public void CheckTriangleArea()
		{
			Triangle triangle = new Triangle(3,4,5);

			Assert.Equal(6, triangle.GetArea());
		}
	}
}
