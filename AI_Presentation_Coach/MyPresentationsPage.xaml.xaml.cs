using AI_Presentation_Coach.Models;
using AI_Presentation_Coach.Services;

namespace AI_Presentation_Coach;

public partial class MyPresentationsPage : ContentPage
{
    private readonly PresentationService _presentationService;

    public MyPresentationsPage(PresentationService presentationService)
    {
        InitializeComponent();

        _presentationService = presentationService;

        LoadPresentations();
    }

    private void LoadPresentations()
    {
        var presentations = _presentationService.GetPresentations();

        PresentationsContainer.Children.Clear();

        foreach (var presentation in presentations)
        {
            var presentationBorder = new Border
            {
                Padding = 18,
                StrokeThickness = 1,
                BackgroundColor = Colors.White,
                StrokeShape = new Microsoft.Maui.Controls.Shapes.RoundRectangle
                {
                    CornerRadius = 16
                }
            };

            var layout = new VerticalStackLayout
            {
                Spacing = 6
            };

            var titleLabel = new Label
            {
                Text = presentation.Title,
                FontSize = 19,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromArgb("#171717")
            };

            var topicLabel = new Label
            {
                Text = $"Topic: {presentation.Topic}",
                FontSize = 14,
                TextColor = Color.FromArgb("#666666")
            };

            var audienceLabel = new Label
            {
                Text = $"Audience: {presentation.Audience}",
                FontSize = 14,
                TextColor = Color.FromArgb("#666666")
            };

            var typeLabel = new Label
            {
                Text = $"Type: {presentation.PresentationType}",
                FontSize = 14,
                TextColor = Color.FromArgb("#666666")
            };

            layout.Children.Add(titleLabel);
            layout.Children.Add(topicLabel);
            layout.Children.Add(audienceLabel);
            layout.Children.Add(typeLabel);

            presentationBorder.Content = layout;

            PresentationsContainer.Children.Add(presentationBorder);
        }
    }
}