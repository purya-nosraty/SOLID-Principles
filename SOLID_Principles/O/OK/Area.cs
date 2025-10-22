namespace SOLID_Principles.O.OK
{
	public static class Area
	{
		public static double CalculateArea(IShape shape)
		{
			return shape.Area();
		}
	}

	public interface IShape
	{
		double Area();
	}

	public class Circle : IShape
	{
		public int Radius { get; set; }
		public double Area() => Math.Pow(Radius, 2) * 3.14;
	}

	public class Square : IShape
	{
		public int Side { get; set; }
		public double Area() => Math.Pow(Side, 2);
	}
}