using AI_Presentation_Coach.Models;

namespace AI_Presentation_Coach;

public partial class PresentationOutlinePage : ContentPage
{
    private readonly Presentation _presentation;

    public PresentationOutlinePage(Presentation presentation)
    {
        InitializeComponent();

        _presentation = presentation;
    }
}

