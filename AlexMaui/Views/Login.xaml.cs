using AlexMaui.Models;
namespace AlexMaui.Views;

public partial class Login : ContentPage
{
    public readonly BlogMvcContext _blogMvcContext;


    public Login(BlogMvcContext blogMvcContext)
	{
        InitializeComponent();
        _blogMvcContext = blogMvcContext;
    }

    private void OnCounterClicked(object sender, EventArgs e) {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        List<Admin> admins = _blogMvcContext.Admins.ToList();

        var navigation = new NavigationPage(new Views.Home());
        Application.Current.MainPage = navigation;
    }
}