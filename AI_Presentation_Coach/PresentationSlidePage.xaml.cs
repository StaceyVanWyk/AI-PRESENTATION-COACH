using AI_Presentation_Coach.Models;

namespace AI_Presentation_Coach;

public partial class PresentationSlidePage : ContentPage
{
    private readonly List<PresentationSlide> _slides;

    public PresentationSlidePage(List<PresentationSlide> slides)
    {
        InitializeComponent();

        _slides = slides;

        foreach(var slide in _slides)
        {
            var slideFrame = new Frame
            {
                Padding = 15,
                CornerRadius = 12,
                BackgroundColor = Color.FromArgb("#F0F0F0"),
                
            };

            var slideLayout = new VerticalStackLayout
            {
                Spacing = 10
            };

            var slideNumberLabel = new Label
            {
                Text = $"Slide {slide.SlideNumber}",
                FontSize = 18,
                FontAttributes = FontAttributes.Bold
            };

            var ContentLabel = new Label
            {
                Text = slide.Content,
                FontSize = 16
            };

            var titleLabel = new Label
            {
                Text = slide.Title,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold
            };

            slideLayout.Children.Add(slideNumberLabel);
            slideLayout.Children.Add(titleLabel);
            slideLayout.Children.Add(ContentLabel);

            slideFrame.Content = slideLayout;
            
            SlidesContainer.Children.Add(slideFrame);
        }
    }
}
