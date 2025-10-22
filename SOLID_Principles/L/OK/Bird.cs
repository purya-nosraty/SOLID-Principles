namespace SOLID_Principles.L.OK
{
	public interface IFly
	{
		void Fly();
	}

	public interface ISwim
	{
		void Swim();
	}

	public class Penguin : ISwim
	{
		public void Swim() { }
	}

	public class Eagle : IFly
	{
		public void Fly() { }
	}
}