namespace RocketTip.Pages
{
    public partial class TipsPage : ContentPage
    {
        public TipsPage()
        {
            InitializeComponent();

            // Set sample total tips amount
            //TotalTipsLabel.Text = "$124.57";

            // Sample data for the transactions
            var transactions = new List<Transaction>
            {
                new Transaction { Avatar = "avatar1.png", Name = "Yara Khalil", DateTime = "Oct 14, 09:45 AM", Amount = "$16.00" },
                new Transaction { Avatar = "avatar2.png", Name = "Sara Ibrahim", DateTime = "Oct 12, 07:12 PM", Amount = "$20.50" },
                new Transaction { Avatar = "avatar3.png", Name = "Ahmed Ismail", DateTime = "Oct 11, 11:32 AM", Amount = "$12.40" },
                new Transaction { Avatar = "avatar4.png", Name = "Reem Khaled", DateTime = "Oct 08, 10:30 AM", Amount = "$21.30" },
                new Transaction { Avatar = "avatar5.png", Name = "Hiba Saleh", DateTime = "Oct 05, 08:50 AM", Amount = "$9.60" },
            };

            // Bind the sample data to the CollectionView
            TransactionsCollectionView.ItemsSource = transactions;
        }

        // Sample model for a transaction
        public class Transaction
        {
            public string Avatar { get; set; }  // Path to avatar image
            public string Name { get; set; }
            public string DateTime { get; set; }
            public string Amount { get; set; }
        }
    }
}
