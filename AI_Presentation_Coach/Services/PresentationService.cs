using AI_Presentation_Coach.Models;

namespace AI_Presentation_Coach.Services;

public class PresentationService
{
    private readonly List<Presentation> _presentations = new();

    public Presentation CreatePresentation(
        string title,
        string topic,
        string audience,
        string presentationType)
    {
        var presentation = new Presentation
        {
            Title = title,
            Topic = topic,
            Audience = audience,
            PresentationType = presentationType
        };

        _presentations.Add(presentation);

        return presentation;
    }

    public List<Presentation> GetPresentations()
    {
        return _presentations;
    }
}

