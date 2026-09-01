namespace AI_Presentation_Coach.ViewModels;

public class CreatePresentationViewModel
{
    public string? ValidateTitle(string? title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            return "Please enter a presentation title.";
        }

        return null;
    }

    public string? ValidateTopic(string? topic)
    {
        if (string.IsNullOrWhiteSpace(topic))
        {
            return "Please enter a presentation topic.";
        }

        return null;
    }

    public string? ValidateAudience(object? audience)
    {
        if (audience == null)
        {
            return "Please select an audience.";
        }

        return null;
    }

    public string? ValidatePresentationType(object? presentationType)
    {
        if (presentationType == null)
        {
            return "Please select a presentation type.";
        }

        return null;
    }
}