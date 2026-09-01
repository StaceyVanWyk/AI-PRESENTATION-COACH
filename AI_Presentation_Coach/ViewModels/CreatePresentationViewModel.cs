namespace AI_Presentation_Coach.ViewModels;

public class CreatePresentationViewModel
{

    
    public bool IsValid(string? title, string? topic)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(topic))
        {
            return false;
        }

        return true;
    }
      public bool IsAudienceSelected(object? audience)
    {
        return audience != null;
    }

    public bool IsPresentationTypeSelected(object? presentationType)
    {
        return presentationType != null;
    }
}