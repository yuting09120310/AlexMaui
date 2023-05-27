namespace AlexMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Views.Login();
	}
}
