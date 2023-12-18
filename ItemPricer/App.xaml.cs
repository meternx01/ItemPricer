using ItemPricer.Services;

namespace ItemPricer;

public partial class App : Application
{
	public static ItemRepository ItemRepo { get; private set; }
	public App(ItemRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		ItemRepo = repo;
	}
}
