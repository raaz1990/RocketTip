namespace RocketTip.Pages;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
	}
	private async void OnSubmitClick(object sender, EventArgs e)
	{

		if (string.IsNullOrWhiteSpace(ForgotPassword.Text))
		{
			await DisplayAlert("Validation Error", "Please enter your Email Address.", "OK");
			return;
		}
	}
}