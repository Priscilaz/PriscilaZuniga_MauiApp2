

namespace PriscilaZuniga_MauiApp2
{
    public partial class MainPage : ContentPage
    {
        
        //Toda esta clase es el code behind que transforma xaml en cs
        public MainPage()
        {
            InitializeComponent();
        }

        //Esto es un event handler
        //Debo conocer le objeto que lanza y algun argumento
        string translatedNumber;

        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = PhoneNumberText.Text;
            translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translatedNumber))
            {
                CallButton.IsEnabled = true;
                CallButton.Text = "Call " + translatedNumber;
            }
            else
            {
                CallButton.IsEnabled = false;
                CallButton.Text = "Call";
            }
        }
        async void OnCall(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + translatedNumber + "?",
                "Yes",
                "No"))
            {
                // TODO: dial the phone
            }
        }

    }

}
