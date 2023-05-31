using AlexMaui.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace AlexMaui.Views;

public partial class Login : ContentPage
{
    public readonly BlogMvcContext _blogMvcContext;


    public Login(BlogMvcContext blogMvcContext)
	{
        InitializeComponent();
        _blogMvcContext = blogMvcContext;
    }

    private async void OnCounterClicked(object sender, EventArgs e) {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        string url = $"http://192.168.1.30:8080/API/admins/{username}&{password}";


        HttpClient client = new HttpClient();
        HttpResponseMessage responseMessage = await client.GetAsync(url);

        if (responseMessage.IsSuccessStatusCode)
        {
            Admin data = await responseMessage.Content.ReadFromJsonAsync<Admin>();


            var navigation = new NavigationPage(new Views.Home());
            Application.Current.MainPage = navigation;
        }
        else
        {
            DisplayAlert("¿ù»~", "±b¸¹±K½X¿ù»~","½T©w");
        }



        
    }
}