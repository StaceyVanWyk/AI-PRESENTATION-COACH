namespace AI_Presentation_Coach;

public partial class CreatePresentationPage : ContentPage
{
	public CreatePresentationPage()
	{
		InitializeComponent();
	}

private async void OnCreatePresentationClicked(object? sender, EventArgs e)
{
    var title = PresentationTitleEntry.Text;

    if (string.IsNullOrWhiteSpace(title))
    {
        await DisplayAlert(
            "Missing Information",
            "Please enter a presentation title.",
            "OK");

        return;
    }

    var topic = PresentationTopicEntry.Text;

    if (string.IsNullOrWhiteSpace(topic))
    {
        await DisplayAlert(
            "Missing Information",
            "Please enter a presentation topic.",
            "OK");

        return;
    }

    var audience = AudiencePicker.SelectedItem;
    var presentationType = PresentationTypePicker.SelectedItem;

    await DisplayAlert(
        "Presentation Details",
        $"Title: {title}\nTopic: {topic}\nAudience: {audience}\nType: {presentationType}",
        "OK");
}
}