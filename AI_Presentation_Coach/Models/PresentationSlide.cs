
namespace AI_Presentation_Coach.Models;

public class PresentationSlide
{
    //Add properties for the slide content, such as title, bullet points,
    //images, and any other revelant information needed for the slide.

    public int SlideNumber {get;set;}

    public string Title {get;set;} = string.Empty;
    
    public string Content {get;set;} = string.Empty;
}