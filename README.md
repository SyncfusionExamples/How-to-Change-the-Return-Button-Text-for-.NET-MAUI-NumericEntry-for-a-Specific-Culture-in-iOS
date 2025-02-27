# How-to-Change-the-Return-Button-Text-for-.NET-MAUI-NumericEntry-for-a-Specific-Culture-in-iOS
This repository contains a sample explaining How to Change the Return Button Text for .NET MAUI NumericEntry for a Specific Culture in iOS 

To modify the return button text of the keyboard, follow these steps to initialize localization for the [NumericEntry](https://www.syncfusion.com/maui-controls/maui-numeric-entry) control: 

**Step 1: Add a New .resx File**

1. In your project, create a new folder named Resources if it doesn’t already exist. 
2. Right-click on the Resources folder and select Add > New Item.... 
3. Choose Resource File and name it `SfNumericEntry.fr-FR.resx` for French localization. 

**Step 2: Add Localization Keys and Values**

1. Open the `SfNumericEntry.fr-FR.resx` file. 
2. In the Name column, add the following keys: return, go, next, done, send, search. 
3. In the Value column, enter the corresponding translated text. 

| Return button type | Key | Value |
| ------ | ------ | ------ |
| Default | return | retour |
| Go | go | aller |
| Done | done | terminé |
| Next | next | suivant |
| Search | search | rechercher |
| Send | send | envoyer |

**Step 3: Configure the Localization for NumericEntry** 

To apply the localization, set the `ResourceManager` for `SfNumericEntryResources` in the `App.xaml.cs` file. 

 
 ```csharp
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
 ```

**Step 4: Initialize NumericEntry control** 

 
 ```
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:inputs="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
             x:Class="NumericEntrySample.MainPage">

    <VerticalStackLayout Spacing="15" Padding="10">
        <inputs:SfNumericEntry 
                HeightRequest="40" 
                Background="Lavender"/>
    </VerticalStackLayout>
    
</ContentPage>

 ```
 
**Output**
 
 
 ![NumericEntryLocalizationGIF.gif](https://support.bolddesk.com/kb/agent/attachment/article/19389/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM2NTE5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5ib2xkZGVzay5jb20ifQ.vCch_rvMfvsgl5numEn6yHX-MG49AsEuxS_E_WyUgvc)

[Download the complete sample from GitHub](https://github.com/SyncfusionExamples/How-to-Change-the-Return-Button-Text-for-.NET-MAUI-NumericEntry-for-a-Specific-Culture-in-iOS)

**Conclusion** 

Hope you enjoyed learning how to change the return button text for the .NET MAUI NumericEntry control based on a specific culture in an iOS application. This ensures that users see culturally appropriate return button text in the numeric entry control keyboard. 

Refer to our [.NET MAUI NumericEntry feature tour](https://www.syncfusion.com/maui-controls/maui-numeric-entry) page to learn about its other groundbreaking feature representations. You can explore our [.NET MAUI NumericEntry documentation](https://help.syncfusion.com/maui/numericentry/getting-started) to understand its features and how to use it.

For current customers, check out our .NET MAUI components from the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to check out our .NET MAUI NumericEntry and other .NET MAUI components.

Please let us know in the following comments section if you have any queries or require clarifications. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfnumericentry). We are always happy to assist you!


