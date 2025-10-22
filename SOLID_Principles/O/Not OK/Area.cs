namespace SOLID_Principles.O.NotOK
{
	public static class Area
	{
		public static double Calculate(object shape)
		{
			if (shape is Circle c)
			{
				return Math.Pow(c.Radius, 2) * 3.14;
			}
			else if (shape is Square s)
			{
				return Math.Pow(s.Side, 2);
			}
			else
			{
				throw new NotImplementedException("Unknown shape!");
			}
		}
	}

	public class Circle
	{
		public int Radius { get; set; }
	}
	public class Square
	{
		public int Side { get; set; }
	}
}