using AI_Presentation_Coach.Models;

namespace AI_Presentation_Coach.Services;

public class PresentationService
{
    public Presentation CreatePresentation(
        string title,
        string topic,
        string audience,
        string presentationType)
    {
        return new Presentation
        {
            Title = title,
            Topic = topic,
            Audience = audience,
            PresentationType = presentationType
        };
    }
} 