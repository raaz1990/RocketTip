namespace RocketTip.Pages;

public partial class CreateAccountPage : ContentPage
{
	public CreateAccountPage()
	{
		InitializeComponent();
	}


	private async void OnLoginTapped(object sender, EventArgs e)
	{
		// Validation for empty username/email and password
		
		// Navigate to the Sign Up page
		await Navigation.PushAsync(new LoginPage());
	}
	private async void OnCreateAccount(object sender, EventArgs e)
	{
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
		if (string.IsNullOrWhiteSpace(ConfirmPasswordEntry.Text))
		{
			await DisplayAlert("Validation Error", "Please enter your Confirm password.", "OK");
			return;
		}
		
		// Check if passwords match
		if (PasswordEntry.Text != ConfirmPasswordEntry.Text)
		{
			await DisplayAlert("Validation Error", "Passwords do not match. Please check again.", "OK");
			return;
		}
		// Navigate to the Sign Up page
		await Navigation.PushAsync(new NewAccountPage());
	}
}