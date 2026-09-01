namespace AI_Presentation_Coach;

public partial class CreatePresentationPage : ContentPage
{
	public CreatePresentationPage()
	{
		InitializeComponent();
	}

	private async void OnCreatePresentationClicked(object? sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///PresentationPage");
	}
}