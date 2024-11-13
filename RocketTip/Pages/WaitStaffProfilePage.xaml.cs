namespace RocketTip.Pages;

public partial class WaitStaffProfilePage : ContentPage
{
	public WaitStaffProfilePage()
	{
		InitializeComponent();
	}
    private async void OnSaveClick(object sender, EventArgs e)
    {
		if (string.IsNullOrWhiteSpace(Email.Text))
		{
			await DisplayAlert("Validation Error", "Please enter a username or email.", "OK");
			return;
		}

		if (string.IsNullOrWhiteSpace(Password.Text))
		{
			await DisplayAlert("Validation Error", "Please enter your password.", "OK");
			return;
		}
		if (string.IsNullOrWhiteSpace(AccountNumber.Text))
		{
			await DisplayAlert("Validation Error", "Please enter your Account Number.", "OK");
			return;
		}
		if (string.IsNullOrWhiteSpace(HoldersName.Text))
		{
			await DisplayAlert("Validation Error", "Please enter Account Holder's Name", "OK");
			return;
		}
		if (string.IsNullOrWhiteSpace(IFSCcode.Text))
		{
			await DisplayAlert("Validation Error", "Please Enter your IFSC code", "OK");
			return;
		}

		// Navigate to the Sign Up page
		await Navigation.PushAsync(new HomePage());
    }
}