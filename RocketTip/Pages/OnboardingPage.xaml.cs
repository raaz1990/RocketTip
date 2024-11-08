namespace RocketTip.Pages;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage()
	{
		InitializeComponent();
	}
	private async void Started_Clicked(object sender, EventArgs e)
	{
		// Navigate to the Sign Up page
		await Navigation.PushAsync(new LoginPage());
	}
}