using AI_Presentation_Coach.Models;
using AI_Presentation_Coach.ViewModels;

namespace AI_Presentation_Coach;

public partial class CreatePresentationPage : ContentPage
{
    private readonly CreatePresentationViewModel _viewModel;

    public CreatePresentationPage()
    {
        InitializeComponent();

        _viewModel = new CreatePresentationViewModel();
    }

    private async void OnCreatePresentationClicked(object? sender, EventArgs e)
    {
        var title = PresentationTitleEntry.Text;
        var topic = PresentationTopicEntry.Text;

        // Validate title and topic through the ViewModel
        if (!_viewModel.IsValid(title, topic))
        {
            await DisplayAlert(
                "Missing Information",
                "Please enter a presentation title and topic.",
                "OK");

            return;
        }

        // Get selected audience
        var audience = AudiencePicker.SelectedItem;

        if (audience == null)
        {
            await DisplayAlert(
                "Missing Information",
                "Please select an audience.",
                "OK");

            return;
        }

        // Get selected presentation type
        var presentationType = PresentationTypePicker.SelectedItem;

        if (presentationType == null)
        {
            await DisplayAlert(
                "Missing Information",
                "Please select a presentation type.",
                "OK");

            return;
        }

        // Create the Presentation model
        var presentation = new Presentation
        {
            Title = title,
            Topic = topic,
            Audience = audience.ToString(),
            PresentationType = presentationType.ToString()
        };

        // Navigate to the outline page and pass the presentation
        await Navigation.PushAsync(
            new PresentationOutlinePage(presentation));
    }
}
