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

        // Validate title and topic
        if (!_viewModel.IsValid(title, topic))
        {
            await DisplayAlert(
                "Missing Information",
                "Please enter a presentation title and topic.",
                "OK");

            return;
        }

        // Get the selected audience
        var audience = AudiencePicker.SelectedItem;

        if (!_viewModel.IsAudienceSelected(audience))
        {
            await DisplayAlert(
                "Missing Information",
                "Please select an audience.",
                "OK");

            return;
        }

        // Get the selected presentation type
        var presentationType = PresentationTypePicker.SelectedItem;

        if (!_viewModel.IsPresentationTypeSelected(presentationType))
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
            Title = title!,
            Topic = topic!,
            Audience = audience.ToString()!,
            PresentationType = presentationType.ToString()!
        };

        // Navigate to the outline page
        await Navigation.PushAsync(
            new PresentationOutlinePage(presentation));
    }
}