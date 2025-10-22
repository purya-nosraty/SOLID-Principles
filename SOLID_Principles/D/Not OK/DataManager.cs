namespace SOLID_Principles.D.NotOK
{
	public static class DataManager
	{
		public static void SaveData()
		{
			SqlServer.Save();
		}
	}

	public static class SqlServer
	{
		public static void Save()
		{
			Console.WriteLine("Saved to Sql Server");
		}
	}
}