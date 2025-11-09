using SPA1.Data;

namespace SPA1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //WIndow of the GUI
            return new Window(new MainPage()) { Title = "SPA MANAGEMENT SYSTEM" };
        }
    }
}
