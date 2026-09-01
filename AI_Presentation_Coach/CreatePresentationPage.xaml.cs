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

    if(audience == null)
        {
            await DisplayAlert(
                "Missing Information",
                "Please select an audience.",
                "OK");

            return;
            

        }
    var presentationType = PresentationTypePicker.SelectedItem;

        if ( presentationType == null)
        {
            await DisplayAlert(
                "Missing Information",
                "Please select a presentation type.",
                "OK");

            return;
        }

    await Shell.Current.GoToAsync("///PresentationOutlinePage");
}

}