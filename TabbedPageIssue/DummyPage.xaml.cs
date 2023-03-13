using TabbedPageIssue.ViewModels;

namespace TabbedPageIssue;

public partial class DummyPage : ContentPage
{
    public DummyPage()
    {
        this.BindingContext = new DummyPageViewModel();
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        this.InvalidateMeasure();
    }
}
