using ItemPricer.Models;

namespace ItemPricer;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		String seaTerm = "a";
		List<Item> items = await App.ItemRepo.GetItems(seaTerm);

		CounterBtn.Text = items.Count.ToString();
	}
}

