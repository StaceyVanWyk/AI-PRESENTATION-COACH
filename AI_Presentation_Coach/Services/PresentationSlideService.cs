using AI_Presentation_Coach.Models;

namespace AI_Presentation_Coach.Services;

public class PresentationSlideService
{
    
  public List<PresentationSlide> GenerateSlides
  ( PresentationOutline outline)
    {
        return new List<PresentationSlide>
        {
            new PresentationSlide
            {
                SlideNumber = 1,
                Title = "Introduction",
                Content = outline.Introduction
            },
            new PresentationSlide
            {
                SlideNumber = 2,
                Content = outline.Problem,

            },

            new PresentationSlide
            {
                SlideNumber = 3,
                Content=outline.Solution,
            },

            new PresentationSlide
            {
                SlideNumber = 4,
                Content=outline.Conclusion,
            }
        };
    }
    
}