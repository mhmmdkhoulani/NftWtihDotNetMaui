namespace MauiApp2;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = this;
	}


    async void GoToHome(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(HomePage), true);
    }
}
