using Syncfusion.Maui.Inputs;
using System.Globalization;
using System.Resources;

namespace NumericEntrySample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the current UI culture
            CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");

            // Initialize the ResourceManager for SfNumericEntry
            SfNumericEntryResources.ResourceManager = new ResourceManager("NumericEntrySample.Resources.SfNumericEntry", Application.Current!.GetType().Assembly);
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}