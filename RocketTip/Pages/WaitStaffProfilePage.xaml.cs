namespace RocketTip.Pages;

public partial class WaitStaffProfilePage : ContentPage
{
	public WaitStaffProfilePage()
	{
		InitializeComponent();
	}
    private async void OnSaveClick(object sender, EventArgs e)
    {
        // Navigate to the Sign Up page
        await Navigation.PushAsync(new HomePage());
    }
}