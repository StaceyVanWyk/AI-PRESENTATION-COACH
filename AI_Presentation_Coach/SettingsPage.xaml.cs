namespace AI_Presentation_Coach;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    // Handles the Personalisation switch
    private async void OnPersonalisationToggled(
        object? sender,
        ToggledEventArgs e)
    {
        await DisplayAlertAsync(
            "Personalisation",
            e.Value
                ? "Personalisation is ON."
                : "Personalisation is OFF.",
            "OK");
    }

    // Handles the Presentation Difficulty picker
    private async void OnDifficultyChanged(
        object? sender,
        EventArgs e)
    {
        if (sender is Picker picker && picker.SelectedIndex >= 0)
        {
            await DisplayAlertAsync(
                "Presentation Difficulty",
                $"You selected: {picker.SelectedItem}",
                "OK");
        }
    }
    private void OnPracticeDurationChanged(
        object? sender,
        ValueChangedEventArgs e)
    {
        PracticeDurationLabel.Text =
            $"{e.NewValue:F0} minutes";
    }

    private async void OnBackClicked(
    object? sender,
    EventArgs e)
    {
        await Navigation.PopAsync();
    }
}