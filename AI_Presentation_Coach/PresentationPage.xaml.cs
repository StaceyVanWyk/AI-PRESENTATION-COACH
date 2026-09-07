namespace AI_Presentation_Coach;

public partial class PresentationPage : ContentPage
{
    public PresentationPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnPreviousClicked(object? sender, EventArgs e)
    {
        await DisplayAlertAsync(
            "Presentation",
            "You are already on the first slide.",
            "OK");
    }

    private async void OnNextClicked(object? sender, EventArgs e)
    {
        await DisplayAlertAsync(
            "Presentation",
            "Next slide functionality will be connected next.",
            "OK");
    }
}