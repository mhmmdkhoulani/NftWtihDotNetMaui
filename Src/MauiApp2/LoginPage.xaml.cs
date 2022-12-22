namespace MauiApp2;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
    async void GoToHome(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(HomePage), true);
    }
}
