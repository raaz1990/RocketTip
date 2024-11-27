namespace RocketTip.Pages;

using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

public partial class QrCodeScannerPage : ContentPage
{
    public QrCodeScannerPage()
    {
        InitializeComponent();
        barcodeView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.All,
            AutoRotate = true,
            Multiple = false
        };
    }

    protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        var firstBarcode = e.Results?.FirstOrDefault();
        if (firstBarcode != null)
        {
            Dispatcher.Dispatch(() =>
            {
                DisplayAlert("QR Code Detected", $"Format: {firstBarcode.Format}\nValue: {firstBarcode.Value}", "OK");
                Console.WriteLine($"Barcode detected: {firstBarcode.Format} -> {firstBarcode.Value}");
            });
        }
    }

    void SwitchCameraButton_Clicked(object sender, EventArgs e)
    {
        barcodeView.CameraLocation = barcodeView.CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;
    }

    void TorchButton_Clicked(object sender, EventArgs e)
    {
        barcodeView.IsTorchOn = !barcodeView.IsTorchOn;
    }
}
