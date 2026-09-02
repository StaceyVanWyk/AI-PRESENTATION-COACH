using AI_Presentation_Coach.Models;
using AI_Presentation_Coach.Services;

namespace AI_Presentation_Coach.ViewModels;

public class PresentationOutlineViewModel
{
    private readonly PresentationOutlineService _outlineService;

    public Presentation Presentation { get; }
    public PresentationOutline Outline { get; }

    public PresentationOutlineViewModel(Presentation presentation)
    {
        Presentation = presentation;

        _outlineService = new PresentationOutlineService();

        Outline = _outlineService.GenerateOutline(presentation);
    }

    public void SaveOutline(
        string introduction,
        string problem,
        string solution,
        string conclusion)
    {
        Outline.Introduction = introduction;
        Outline.Problem = problem;
        Outline.Solution = solution;
        Outline.Conclusion = conclusion;
    }
}