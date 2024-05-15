namespace PriscilaZuniga_MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            //Realiza el proceso de transformacion de cs
            //Normalmente los errores estan en este metodo
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
