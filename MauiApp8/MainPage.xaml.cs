namespace MauiApp8;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var newWindow = new Window(new MyContentPage());

        Application.Current?.OpenWindow(newWindow);
    }
}

public class MyContentPage : ContentPage { }
