using AI_Presentation_Coach.Models;
using AI_Presentation_Coach.Services;

namespace AI_Presentation_Coach.Services;


public class PresentationOutLineViewModel
{
    

    private readonly PresentationOutlineService _outlineServices;
     
     public PresentationOutLineViewModel()
     {
        _outlineServices = new PresentationOutlineService();
     }
     

}
