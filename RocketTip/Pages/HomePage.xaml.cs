namespace RocketTip.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void OnTransactionsClick(object sender, EventArgs e)
    {
        // Navigate to the Sign Up page
        await Navigation.PushAsync(new TipsPage());
    }

}