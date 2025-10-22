namespace SOLID_Principles.I.NotOK
{
	public interface IWorker
	{
		void Work();

		void Eat();
	}

	public class Robot : IWorker
	{
		public void Work()
		{

		}

		public void Eat()
		{
			throw new NotImplementedException("Robot doesn't need to eat!");
		}
	}
}