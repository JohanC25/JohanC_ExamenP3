using SQLite;

namespace JohanC_ExamenP3.Models
{
	[Table("JCMarvel")]
	public class JCMarvel
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string JCNombre { get; set; }
		public string JCDescripcion { get; set; }
		public DateTime DateTime { get; set; }

	}
}
