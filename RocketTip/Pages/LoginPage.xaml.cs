namespace RocketTip.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
	private async void OnLogin(object sender, EventArgs e)
	{
		// Validation for empty username/email and password
		if (string.IsNullOrWhiteSpace(UsernameEntry.Text))
		{
			await DisplayAlert("Validation Error", "Please enter a username or email.", "OK");
			return;
		}

		if (string.IsNullOrWhiteSpace(PasswordEntry.Text))
		{
			await DisplayAlert("Validation Error", "Please enter your password.", "OK");
			return;
		}


		await Navigation.PushAsync(new NewAccountPage());

	}
	private async void OnSignUpTapped(object sender, EventArgs e)
	{
		// Navigate to sign-up page
		await Navigation.PushAsync(new CreateAccountPage());
	}
	
	private async void OnForgotPasswordTapped(object sender, EventArgs e)
	{
		// Navigate to the Sign Up page
		await Navigation.PushAsync(new ForgotPasswordPage());
	}
	

}