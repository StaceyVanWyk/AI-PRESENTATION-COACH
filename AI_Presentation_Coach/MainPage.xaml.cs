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
            await Shell.Current.GoToAsync("///PresentationPage");
        }

        private async void OnCreatePresentationClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///CreatePresentationPage");
        }

        
        private async void OnPracticeClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///PracticePage");
        }
    }
}
