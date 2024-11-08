namespace RocketTip.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void OnSignUpTapped(object sender, EventArgs e)
	{
		// Navigate to the Sign Up page
		await Navigation.PushAsync(new CreateAccountPage());
	}
	private async void OnForgotPasswordTapped(object sender, EventArgs e)
	{
		// Navigate to the Sign Up page
		await Navigation.PushAsync(new ForgotPasswordPage());
	}
	
	private async void OnLogin(object sender, EventArgs e)
	{
		// Navigate to the Sign Up page
		await Navigation.PushAsync(new NewAccountPage());
	}

}