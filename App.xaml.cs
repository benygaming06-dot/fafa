using KurtDhylanMotoShopInventory.Views;

namespace KurtDhylanMotoShopInventory;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var navigationPage = new NavigationPage(new MainPage());

        navigationPage.BarBackgroundColor = Color.FromArgb("#0B0B0D");
        navigationPage.BarTextColor = Colors.White;

        return new Window(navigationPage);
    }
}
