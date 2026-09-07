namespace AI_Presentation_Coach;

public partial class AICoachPage : ContentPage
{
    public AICoachPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnAnalyseClicked(object? sender, EventArgs e)
    {
        await DisplayAlertAsync(
            "AI Coach",
            "Presentation analysis will be connected next.",
            "OK");
    }
}