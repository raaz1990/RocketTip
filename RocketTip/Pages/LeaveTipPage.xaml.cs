namespace RocketTip.Pages;

public partial class LeaveTipPage : ContentPage
{
    private Button selectedButton;

    public LeaveTipPage()
    {
        InitializeComponent();
    }

    private void OnPercentageClicked(object sender, EventArgs e)
    {

#if ANDROID || IOS
        if (sender is Button clickedButton)
        {
            // Clear previous selection
            if (selectedButton != null)
            {
                DeselectButton(selectedButton);
            }

            // Highlight the selected button
            SelectButton(clickedButton);
            selectedButton = clickedButton;

            // Update Tip Amount
            UpdateTipAmount();
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

    private void UpdateTipAmount()
    {

#if ANDROID || IOS
        double billAmount = double.TryParse(TotalBillEntry.Text, out double result) ? result : 0;
        double tipPercentage = selectedButton != null ? GetTipPercentage(selectedButton.Text) : 0;
        double tipAmount = billAmount * tipPercentage / 100 + 0.50; // Including fee of $0.50
        TipAmountLabel.Text = $"${tipAmount:F2}";
#endif
    }

    private double GetTipPercentage(string buttonText)
    {
        return buttonText switch
        {
            "10%" => 10,
            "15%" => 15,
            "20%" => 20,
            _ => 0
        };
    }
    private async void OnClainTapped(object sender, EventArgs e)
    {
        // Navigate to sign-up page
        await Navigation.PushAsync(new TipsDetailPage());
    }
}