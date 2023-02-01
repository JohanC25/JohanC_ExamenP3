using JohanC_ExamenP3.Views;

namespace JohanC_ExamenP3;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(JCMarvelItemPage), typeof(JCMarvelItemPage));
	}
}
