
using System;

namespace AreaSolverLibrary
{
	public class Triangle : IFigure
	{
		public double SideA { get; set; }

		public double SideB { get; set; }

		public double SideC { get; set; }

		public Triangle(double a,double b,double c)
		{
			SideA = a;
			SideB = b;
			SideC = c;
		}

		public Triangle()
		{

		}

		/// <summary>
		/// Площадь треугольника
		/// </summary>
		/// <returns></returns>
		public double GetArea()
		{
			double halfPer = (SideA + SideB + SideC)/2;

			return Math.Sqrt(halfPer * (halfPer - SideA) * (halfPer - SideB) * (halfPer - SideC));
		}

		/// <summary>
		/// Проверка треугольника на прямоуголность
		/// </summary>
		/// <returns></returns>
		public bool IsRectangular()
		{
			double max = Math.Max(SideA, SideB);

			if (max == SideA)
			{
				if (max > SideC)
				{
					return Math.Pow(max,2) == Math.Pow(SideB,2) + Math.Pow(SideC,2);
				}
				else
				{
					return Math.Pow(SideC,2) == Math.Pow(SideB,2) + Math.Pow(max,2);
				}
			}
			else
			{
				if (max > SideC)
				{
					return Math.Pow(max,2) == Math.Pow(SideA,2) + Math.Pow(SideC,2);
				}
				else
				{
					return Math.Pow(SideC,2) == Math.Pow(SideA,2) + Math.Pow(max,2);
				}
			}
		}
	}
}
