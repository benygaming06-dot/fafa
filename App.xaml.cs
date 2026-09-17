namespace KurtDhylanMotoShopInventory;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new Views.MainPage())
        {
            BarBackgroundColor = Color.FromArgb("#0B0B0D"),
            BarTextColor = Colors.White
        };
    }
}
