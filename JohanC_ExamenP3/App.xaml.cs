using JohanC_ExamenP3.Data;

namespace JohanC_ExamenP3;

public partial class App : Application
{
	public static JCMarvelDatabase MarvelRepo { get; private set; }
	public App(JCMarvelDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		MarvelRepo = repo;
	}
}
