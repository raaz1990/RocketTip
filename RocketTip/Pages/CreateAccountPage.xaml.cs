namespace RocketTip.Pages;

public partial class CreateAccountPage : ContentPage
{
	public CreateAccountPage()
	{
		InitializeComponent();
	}
	private async void OnLoginTapped(object sender, EventArgs e)
	{
		// Navigate to the Sign Up page
		await Navigation.PushAsync(new LoginPage());
	}
	private async void OnCreateAccount(object sender, EventArgs e)
	{
		// Navigate to the Sign Up page
		await Navigation.PushAsync(new NewAccountPage());
	}
}