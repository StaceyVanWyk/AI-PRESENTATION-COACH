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

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///PresentationPage"); //// 
        }

        private async void OnCreatePresentationClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///CreatePresentationPage");
        }
         
        private async void OnPracticeClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///PracticePage");
        }

        private async void OnMyPresentationsClicked(object? sender, EventArgs e)
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
    }
}