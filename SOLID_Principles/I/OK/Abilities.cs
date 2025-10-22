namespace SOLID_Principles.I.OK
{
	public interface IWalkable
	{
		void Walk();
	}

	public interface IEatable
	{
		void Eat();
	}

	public class Robot : IWalkable
	{
		public void Walk() { }
	}

	public class Human : IWalkable, IEatable
	{
		public void Walk() { }

		public void Eat() { }
	}
}