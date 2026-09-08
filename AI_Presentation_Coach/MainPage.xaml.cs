using AI_Presentation_Coach.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AI_Presentation_Coach
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCreatePresentationClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///CreatePresentationPage");
        }

        private async void OnMyPresentationsTapped(object? sender, TappedEventArgs e)
        {
            var presentationService =
                Application.Current?
                    .Handler?
                    .MauiContext?
                    .Services
                    .GetService<PresentationService>();

            if (presentationService == null)
            {
                await DisplayAlertAsync(
                    "Error",
                    "Presentation service could not be found.",
                    "OK");

                return;
            }

            await Navigation.PushAsync(
                new MyPresentationsPage(presentationService));
        }

        private async void OnPracticeTapped(object? sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("///PracticePage");
        }

        private async void OnAICoachTapped(object? sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new AICoachPage());
        }

        private async void OnSettingsTapped(
    object? sender,
    TappedEventArgs e)
        {
            await Navigation.PushAsync(
                new SettingsPage());
        }
    }
}