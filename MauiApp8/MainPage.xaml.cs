namespace MauiApp8
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            GC.Collect();
            var newWindow = new Window(new ContentPage());

            Application.Current?.OpenWindow(newWindow);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }

}
