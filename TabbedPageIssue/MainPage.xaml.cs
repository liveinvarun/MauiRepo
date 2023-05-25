namespace TabbedPageIssue;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        this.BindingContext = new ViewModels.MainPageViewModel();
        InitializeComponent();

    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        App.NavigationService.PushAsync(new DummyPage());
    }

    private void OnDummyClicked(object sender, EventArgs e)
    {
        App.NavigationService.PushModalAsync(new DummyPage());
    }
 protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

}


public class Monkey
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Details { get; set; }
    public string ImageUrl { get; set; }
}


