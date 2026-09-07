using AI_Presentation_Coach.Models;

namespace AI_Presentation_Coach;

public partial class PresentationSlidePage : ContentPage
{
    private readonly List<PresentationSlide> _slides;

    public PresentationSlidePage(List<PresentationSlide> slides)
    {
        InitializeComponent();

        _slides = slides;

        foreach (var slide in _slides)
        {
            var slideNumberLabel = new Label
            {
                Text = $"SLIDE {slide.SlideNumber:00}",
                FontSize = 11,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromArgb("#6C3BDE")
            };

            var slideNumberBorder = new Border
            {
                Padding = new Thickness(10, 6),
                BackgroundColor = Color.FromArgb("#F0EBFF"),
                StrokeThickness = 0,
                StrokeShape = new Microsoft.Maui.Controls.Shapes.RoundRectangle
                {
                    CornerRadius = 8
                },
                Content = slideNumberLabel,
                HorizontalOptions = LayoutOptions.Start
            };

            var titleLabel = new Label
            {
                Text = slide.Title,
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromArgb("#171717"),
                LineBreakMode = LineBreakMode.WordWrap
            };

            var divider = new BoxView
            {
                HeightRequest = 3,
                WidthRequest = 55,
                BackgroundColor = Color.FromArgb("#6C3BDE"),
                HorizontalOptions = LayoutOptions.Start,
                Margin = new Thickness(0, 2, 0, 5)
            };

            var contentLabel = new Label
            {
                Text = slide.Content,
                FontSize = 15,
                TextColor = Color.FromArgb("#555555"),
                LineBreakMode = LineBreakMode.WordWrap,
                LineHeight = 1.3
            };

            var aiLabel = new Label
            {
                Text = "✦ AI generated content",
                FontSize = 11,
                TextColor = Color.FromArgb("#888888"),
                Margin = new Thickness(0, 8, 0, 0)
            };

            var slideLayout = new VerticalStackLayout
            {
                Spacing = 12
            };

            slideLayout.Children.Add(slideNumberBorder);
            slideLayout.Children.Add(titleLabel);
            slideLayout.Children.Add(divider);
            slideLayout.Children.Add(contentLabel);
            slideLayout.Children.Add(aiLabel);

            var slideBorder = new Border
            {
                Padding = new Thickness(22),
                Margin = new Thickness(0, 2),
                BackgroundColor = Colors.White,
                Stroke = Color.FromArgb("#E2E2EA"),
                StrokeThickness = 1,
                StrokeShape = new Microsoft.Maui.Controls.Shapes.RoundRectangle
                {
                    CornerRadius = 20
                },
                Content = slideLayout
            };

            SlidesContainer.Children.Add(slideBorder);
        }
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnPresentClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new PresentationPage());
    }

    private async void OnStartPresentingClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new PresentationPage());
    }
}