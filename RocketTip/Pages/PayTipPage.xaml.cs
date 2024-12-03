using Microsoft.Maui.Controls;

namespace RocketTip.Pages
{
    public partial class PayTipPage : ContentPage
    {
        public PayTipPage()
        {
            InitializeComponent();
        }

        // Method to Show the Popup
        private void ShowPopup(string paymentMethod)
        {
            // Update popup content based on the payment method
            switch (paymentMethod)
            {
                case "ipay":
                    PopupImage.Source = "rockettipslogowithroce.png";
                    PopupLabel.Text = "You selected iPay. Your Tip Payment Was Successful.";
                    break;
                case "gpay":
                    PopupImage.Source = "rockettipslogowithroce.png";
                    PopupLabel.Text = "You selected GPay. Your Tip Payment Was Successful.";
                    break;
                default:
                    PopupImage.Source = "rockettipslogowithroce.png";
                    PopupLabel.Text = "Your Tip Payment Was Successful.";
                    break;
            }

            // Show the popup
            PopupView.IsVisible = true;
        }

        // Method to Hide the Popup
        private void ClosePopup(object sender, EventArgs e)
        {
            PopupView.IsVisible = false;
        }

        // Handle Payment Method Tap
        private void OnPaymentMethodTapped(object sender, TappedEventArgs e)
        {
            string paymentMethod = e.Parameter?.ToString();
            ShowPopup(paymentMethod);
        }
    }
}
