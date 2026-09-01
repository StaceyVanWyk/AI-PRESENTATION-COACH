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
		var topic = PresentationTopicEntry.Text;
		var audience = AudiencePicker.SelectedItem;
		var presentationType = PresentationTypePicker.SelectedItem;
		
		await DisplayAlert("Presentation Details",
    $"Title: {title}\nTopic: {topic}\nAudience: {audience}\nType: {presentationType}",
    "OK");
		
}
}