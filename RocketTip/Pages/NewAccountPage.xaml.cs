namespace RocketTip.Pages;

public partial class NewAccountPage : ContentPage
{
	public NewAccountPage()
	{
		InitializeComponent();
	}

    private async void OnSaveClick(object sender, EventArgs e)
    {
        // Navigate to the Sign Up page
        await Navigation.PushAsync(new WaitStaffProfilePage());
    }
}