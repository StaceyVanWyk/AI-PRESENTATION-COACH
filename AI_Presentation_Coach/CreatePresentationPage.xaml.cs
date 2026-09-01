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

        // Validate title
        var titleError = _viewModel.ValidateTitle(title);

        if (titleError != null)
        {
            await DisplayAlert(
                "Missing Information",
                titleError,
                "OK");

            return;
        }

        var topic = PresentationTopicEntry.Text;

        // Validate topic
        if (string.IsNullOrWhiteSpace(topic))
        {
            await DisplayAlert(
                "Missing Information",
                "Please enter a presentation topic.",
                "OK");

            return;
        }

        var audience = AudiencePicker.SelectedItem;

        // Validate audience
        if (!_viewModel.IsAudienceSelected(audience))
        {
            await DisplayAlert(
                "Missing Information",
                "Please select an audience.",
                "OK");

            return;
        }

        var presentationType = PresentationTypePicker.SelectedItem;

        // Validate presentation type
        if (!_viewModel.IsPresentationTypeSelected(presentationType))
        {
            await DisplayAlert(
                "Missing Information",
                "Please select a presentation type.",
                "OK");

            return;
        }

        // Create Presentation model
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
