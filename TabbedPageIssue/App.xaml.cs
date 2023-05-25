namespace TabbedPageIssue;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage();
        App.NavigationService = MainPage.Navigation;
        App.NavigationService.PushAsync(new MainPage());
    }

    public static INavigation NavigationService { get; private set; }
}

