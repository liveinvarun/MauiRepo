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



}


public class Monkey
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Details { get; set; }
    public string ImageUrl { get; set; }
}


