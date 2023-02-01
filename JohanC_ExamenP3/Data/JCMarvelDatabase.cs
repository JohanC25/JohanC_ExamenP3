using SQLite;
using JohanC_ExamenP3.Models;

namespace JohanC_ExamenP3.Data
{
	public class JCMarvelDatabase
	{
		string _dbPath;
		private SQLiteConnection conn;

		public JCMarvelDatabase(string DatabasePath)
		{
			_dbPath = DatabasePath;
		}

		private void Init()
		{
			if (conn != null)
				return;
			conn = new SQLiteConnection(_dbPath);
			conn.CreateTable<JCMarvel>();
		}
		public int AddNewMarvel(JCMarvel marvel)
		{
			Init();
			if (marvel.Id != 0)
			{
				return conn.Update(marvel);
			}
			else
			{
				return conn.Insert(marvel);
			}
		}

		public List<JCMarvel> GetAllMarvel()
		{
			Init();
			List<JCMarvel> marvel = conn.Table<JCMarvel>().ToList();
			return marvel;
		}

		public int DeleteMarvel(JCMarvel item)
		{
			Init();
			return conn.Delete(item);
		}
	}
}
