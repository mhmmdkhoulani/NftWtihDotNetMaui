using MauiApp2.Models;
namespace MauiApp2;

public partial class HomePage : ContentPage
{

    
	public HomePage()
	{
		InitializeComponent();

        BindingContext = this;
	}


    void OpenFlayout(object sender, EventArgs args)
    {
         Shell.Current.FlyoutIsPresented = true;
    }
}
