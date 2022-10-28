namespace TabbedPageIssue;

public partial class DummyPage : ContentPage
{
    public DummyPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        this.InvalidateMeasure();
    }
}
