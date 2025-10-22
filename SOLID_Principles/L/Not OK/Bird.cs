namespace SOLID_Principles.L.NotOK
{
	public class Bird
	{
		public virtual void Fly() { }
	}

	public class Penguin : Bird
	{
		public override void Fly()
		{
			throw new NotImplementedException("Penguin can not fly!");
		}
	}
}