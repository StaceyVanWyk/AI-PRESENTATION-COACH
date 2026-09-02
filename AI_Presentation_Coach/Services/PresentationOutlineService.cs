using AI_Presentation_Coach.Models;

namespace AI_Presentation_Coach.Services;

public class PresentationOutlineService
{
    public PresentationOutline GenerateOutline(Presentation presentation)
    {
        return new PresentationOutline
        {
            Introduction = $"Introduce the topic: {presentation.Topic}. Explain why it is important to the {presentation.Audience}.",

            Problem = $"Explain the main problem or challenge related to {presentation.Topic}.",

            Solution = $"Present a solution related to {presentation.Topic} that is suitable for a {presentation.PresentationType}.",

            Conclusion = $"Summarise the key points about {presentation.Topic} and provide a strong closing message."
        };
    }
}