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
            var titleLabel = new Label
            {
                Text = presentation.Title,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromArgb("#171717")
            };

            var topicLabel = new Label
            {
                Text = presentation.Topic,
                FontSize = 14,
                TextColor = Color.FromArgb("#666666")
            };

            var detailsLabel = new Label
            {
                Text = $"{presentation.Audience} • {presentation.PresentationType}",
                FontSize = 13,
                TextColor = Color.FromArgb("#888888")
            };

            var viewButton = new Button
            {
                Text = "View →",
                BackgroundColor = Color.FromArgb("#6C3BDE"),
                TextColor = Colors.White,
                CornerRadius = 10,
                Padding = new Thickness(16, 8),
                HorizontalOptions = LayoutOptions.End
            };

            var cardLayout = new VerticalStackLayout
            {
                Spacing = 8
            };

            cardLayout.Children.Add(titleLabel);
            cardLayout.Children.Add(topicLabel);
            cardLayout.Children.Add(detailsLabel);

            var buttonLayout = new Grid
            {
                Margin = new Thickness(0, 8, 0, 0)
            };

            buttonLayout.Children.Add(viewButton);

            cardLayout.Children.Add(buttonLayout);

            var presentationBorder = new Border
            {
                Padding = 18,
                BackgroundColor = Colors.White,
                StrokeThickness = 1,
                Stroke = Color.FromArgb("#E5E5EA"),
                StrokeShape = new Microsoft.Maui.Controls.Shapes.RoundRectangle
                {
                    CornerRadius = 16
                },
                Content = cardLayout
            };

            PresentationsContainer.Children.Add(presentationBorder);
        }
    }
}