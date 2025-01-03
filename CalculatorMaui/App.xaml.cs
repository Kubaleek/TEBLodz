namespace CalculatorMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 340;
            const int newHeight = 580;

            window.Width = newWidth;
            window.Height = newHeight;
            window.MinimumWidth = 340;
            window.MinimumHeight = 580;

            return window;

        }
    }
}
