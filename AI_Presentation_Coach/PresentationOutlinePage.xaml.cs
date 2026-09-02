using AI_Presentation_Coach.Models;
using AI_Presentation_Coach.ViewModels;

namespace AI_Presentation_Coach;

public partial class PresentationOutlinePage : ContentPage
{
    private readonly PresentationOutlineViewModel _viewModel;

    public PresentationOutlinePage(Presentation presentation)
    {
        InitializeComponent();

        _viewModel = new PresentationOutlineViewModel(presentation);

        // Display presentation information
        PresentationTitleLabel.Text = _viewModel.Presentation.Title;
        PresentationTopicLabel.Text = _viewModel.Presentation.Topic;
        AudienceLabel.Text = _viewModel.Presentation.Audience;
        PresentationTypeLabel.Text = _viewModel.Presentation.PresentationType;

        // Display the generated outline
        IntroductionEditor.Text = _viewModel.Outline.Introduction;
        ProblemEditor.Text = _viewModel.Outline.Problem;
        SolutionEditor.Text = _viewModel.Outline.Solution;
        ConclusionEditor.Text = _viewModel.Outline.Conclusion;
    }

    private async void OnSaveOutlineClicked(object? sender, EventArgs e)
    {
        _viewModel.SaveOutline(
            IntroductionEditor.Text ?? string.Empty,
            ProblemEditor.Text ?? string.Empty,
            SolutionEditor.Text ?? string.Empty,
            ConclusionEditor.Text ?? string.Empty
        );

        await DisplayAlertAsync(
            "Outline Saved",
            "Your presentation outline has been saved successfully.",
            "OK"
        );
    }

    private async void OnGenerateSlidesClicked(object? sender, EventArgs e)
    { 
        _viewModel.GenerateSlides();

        await Navigation.PushAsync(
            new PresentationSlidePage(_viewModel.Slides));
        
            
        
    }
}