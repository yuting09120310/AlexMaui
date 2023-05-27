using AlexMaui.Models;

namespace AlexMaui;

public partial class App : Application
{
	public App(BlogMvcContext blogMvcContext)
	{
        InitializeComponent();
        MainPage = new Views.Login(blogMvcContext);
    }
}
