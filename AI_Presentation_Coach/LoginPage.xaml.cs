namespace AI_Presentation_Coach;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }

    private async void OnCreateAccountClicked(object? sender, EventArgs e)
    {
         await DisplayAlertAsync(
        "Login",
        "Login functionality will be added next.",
        "OK");
    }
}