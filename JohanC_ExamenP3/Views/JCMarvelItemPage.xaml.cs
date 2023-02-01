using JohanC_ExamenP3.Models;

namespace JohanC_ExamenP3.Views;

[QueryProperty("Item", "Item")]
public partial class JCMarvelItemPage : ContentPage
{
	public JCMarvel Item
	{
		get => BindingContext as JCMarvel;
		set => BindingContext = value;
	}

	public JCMarvelItemPage()
	{
		InitializeComponent();
	}

	private void OnSaveClicked(object sender, EventArgs e)
	{
		Item.DateTime = DateTime.Parse(FechaHora.Text);
		App.MarvelRepo.AddNewMarvel(Item);
		Shell.Current.GoToAsync("///JCMarvelListPage");
	}

	private void OnCancelClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("///JCMarvelListPage");
	}

	private void OnDeleteClicked(object sender, EventArgs e)
	{
		App.MarvelRepo.DeleteMarvel(Item);
		Shell.Current.GoToAsync("///JCMarvelListPage");
	}
}