using AI_Presentation_Coach.Models;
using AI_Presentation_Coach.ViewModels;
using AI_Presentation_Coach.Services;


namespace AI_Presentation_Coach;

public partial class CreatePresentationPage : ContentPage
{
    private readonly CreatePresentationViewModel _viewModel;
    private readonly PresentationService _presentationService;

    public CreatePresentationPage()
    {
        InitializeComponent();

        _viewModel = new CreatePresentationViewModel();
        _presentationService = new PresentationService();
    }

    private async void OnCreatePresentationClicked(object? sender, EventArgs e)
    {
        var title = PresentationTitleEntry.Text;

        // Validate title
        var titleError = _viewModel.ValidateTitle(title);

        if (titleError != null)
        {
            await DisplayAlertAsync(
                "Missing Information",
                titleError,
                "OK");

            return;
        }

        var topic = PresentationTopicEntry.Text;

        // Validate topic
        var topicError = _viewModel.ValidateTopic(topic);

        if (topicError != null)
        {
            await DisplayAlertAsync(
                "Missing Information",
                topicError,
                "OK");

            return;
        }

        var audience = AudiencePicker.SelectedItem;

        // Validate audience
        var audienceError = _viewModel.ValidateAudience(audience);

        if (audienceError != null)
        {
            await DisplayAlertAsync(
                "Missing Information",
                audienceError,
                "OK");

            return;
        }

        var presentationType = PresentationTypePicker.SelectedItem;

        // Validate presentation type
        var presentationTypeError =
            _viewModel.ValidatePresentationType(presentationType);

        if (presentationTypeError != null)
        {
            await DisplayAlertAsync(
                "Missing Information",
                presentationTypeError,
                "OK");

            return;
        }

        var presentation = _presentationService.CreatePresentation(
        title!,
        topic!,
        audience.ToString()!,
        presentationType.ToString()!);

        // Navigate to the outline page
        await Navigation.PushAsync(
            new PresentationOutlinePage(presentation));
    }
}