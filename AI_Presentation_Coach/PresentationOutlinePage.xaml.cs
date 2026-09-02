using AI_Presentation_Coach.Models;
using AI_Presentation_Coach.Services;

namespace AI_Presentation_Coach;

public partial class PresentationOutlinePage : ContentPage
{
    private readonly Presentation _presentation;
    private readonly PresentationOutlineService _outlineService;

    public PresentationOutlinePage(Presentation presentation)
    {
        InitializeComponent();

        _presentation = presentation;

        _outlineService = new PresentationOutlineService();

        // Display presentation information
        PresentationTitleLabel.Text = _presentation.Title;
        PresentationTopicLabel.Text = _presentation.Topic;
        AudienceLabel.Text = _presentation.Audience;
        PresentationTypeLabel.Text = _presentation.PresentationType;

        // Generate the presentation outline
        var outline = _outlineService.GenerateOutline(_presentation);

        // Display the generated outline
        IntroductionLabel.Text = outline.Introduction;
        ProblemLabel.Text = outline.Problem;
        SolutionLabel.Text = outline.Solution;
        ConclusionLabel.Text = outline.Conclusion;
    }
}
