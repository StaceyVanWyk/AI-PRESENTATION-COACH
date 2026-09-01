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
      public bool IsAudienceSelected(object? audience)
    {
        return audience != null;
    }

    public bool IsPresentationTypeSelected(object? presentationType)
    {
        return presentationType != null;
    }
}