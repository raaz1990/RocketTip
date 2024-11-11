using Microsoft.Maui.Controls;
using RocketTip.Pages;
namespace RocketTip.Controls
{
    public partial class BottomTabBar : ContentView
    {
        public BottomTabBar()
        {
            InitializeComponent();
        }

        private async void OnHomeTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        private async void OnReferTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        private async void OnNewTipTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewTipPage());
        }

        private async void OnTransactionsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TipsPage());
        }

        private async void OnSettingsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WaitStaffProfilePage());
        }
    }
}
