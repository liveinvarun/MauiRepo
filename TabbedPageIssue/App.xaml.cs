namespace TabbedPageIssue;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage();
        App.NavigationService = MainPage.Navigation;
        App.NavigationService.PushAsync(new HomePage());
    }

    public static INavigation NavigationService { get; private set; }
}

