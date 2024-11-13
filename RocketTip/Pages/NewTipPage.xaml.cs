using System.Windows.Input;

namespace RocketTip.Pages;

public partial class NewTipPage : ContentPage
{
	public NewTipPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public ICommand OpenMenuCommand => new Command(() =>
	{
		Shell.Current.FlyoutIsPresented = true;
	});
}