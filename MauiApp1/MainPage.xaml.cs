namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Navigate()
        {
            await Navigation.PushAsync(new KeyBoardPage());
 
        }

     

        private void KeyboardBtn_Clicked(object sender, EventArgs e)
        {
            Navigate();

        }
    }

}
