namespace RocketTip.Pages;
public partial class TipsDetailPage : ContentPage
{
    private Button selectedYaraButton;
    private Button selectedReemButton;

    public TipsDetailPage()
    {
        InitializeComponent();
    }

    private void OnPercentageClicked(object sender, EventArgs e)
    {
#if ANDROID || IOS
        if (sender is Button clickedButton)
        {
            // Determine if the clicked button is in Yara or Reem's group
            if (clickedButton == YaraButton10 || clickedButton == YaraButton15 || clickedButton == YaraButton20)
            {
                // Clear previous selection for Yara
                if (selectedYaraButton != null)
                    DeselectButton(selectedYaraButton);

                // Highlight the selected button
                SelectButton(clickedButton);
                selectedYaraButton = clickedButton;
            }
            else if (clickedButton == ReemButton10 || clickedButton == ReemButton15 || clickedButton == ReemButton20)
            {
                // Clear previous selection for Reem
                if (selectedReemButton != null)
                    DeselectButton(selectedReemButton);

                // Highlight the selected button
                SelectButton(clickedButton);
                selectedReemButton = clickedButton;
            }
        }
#endif
    }

    private void SelectButton(Button button)
    {
        button.BackgroundColor = Color.FromArgb("#FF6B6B"); // Highlight color
        button.TextColor = Colors.White;
        button.BorderColor = Colors.Transparent;
    }

    private void DeselectButton(Button button)
    {
        button.BackgroundColor = Colors.White; // Default color
        button.TextColor = Colors.Black;
        button.BorderColor = Colors.Black;
    }
    private async void OnClainTapped(object sender, EventArgs e)
    {
        // Navigate to sign-up page
        await Navigation.PushAsync(new PayTipPage());
    }
}