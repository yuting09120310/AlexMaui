namespace AlexMaui.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e) {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        var navigation = new NavigationPage(new Views.Home());
        Application.Current.MainPage = navigation;
    }
}