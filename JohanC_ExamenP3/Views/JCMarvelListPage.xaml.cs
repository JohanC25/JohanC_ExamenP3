using JohanC_ExamenP3.Models;

namespace JohanC_ExamenP3.Views;

public partial class JCMarvelListPage : ContentPage
{
	public JCMarvelListPage()
	{
		InitializeComponent();
		List<JCMarvel> marvel = App.MarvelRepo.GetAllMarvel();
		BindingContext = this;
		marvelList.ItemsSource = marvel;
	}

	async void OnItemAdded(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(JCMarvelItemPage), true, new Dictionary<string, object>
		{
			["Item"] = new JCMarvel()
		});
	}

	public void Update()
	{
		List<JCMarvel> marvel = App.MarvelRepo.GetAllMarvel();
		marvelList.ItemsSource = marvel;
	}

	protected override void OnAppearing()
	{
		Update();
	}

	async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(JCMarvelItemPage), true, new Dictionary<string, object>
		{
			["Item"] = (JCMarvel)e.CurrentSelection.FirstOrDefault()
		});
	}
}