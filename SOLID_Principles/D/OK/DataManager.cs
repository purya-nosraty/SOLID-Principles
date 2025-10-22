namespace SOLID_Principles.D.OK
{
	public interface IDatabase
	{
		void Save();
	}

	public class SqlServer : IDatabase
	{
		public void Save()
		{
			Console.WriteLine("Saved to Sql Server");
		}
	}

	public class PostgreSql : IDatabase
	{
		public void Save()
		{
			Console.WriteLine("Saved to PostgreSql");
		}
	}

	public class DataManager(IDatabase database)
	{
		public IDatabase Database { get; } = database;

		public void Save()
		{
			Database.Save();
		}
	}
}