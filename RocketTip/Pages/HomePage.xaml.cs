using System.Windows.Input;

namespace RocketTip.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public ICommand OpenMenuCommand => new Command(() =>
	{
		Shell.Current.FlyoutIsPresented = true;
	});
	private async void OnTransactionsClick(object sender, EventArgs e)
    {
        // Navigate to the Sign Up page
        await Navigation.PushAsync(new TipsPage());
    }

}