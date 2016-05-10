using System;
using Xamarin.Forms;

namespace CodePlusXaml
{
    public partial class CodePlusXamlPage : ContentPage
    {
        public CodePlusXamlPage()
        {
            InitializeComponent();

            // Demonstrate the ColorTypeConverter
            var converter = new ColorTypeConverter();
            var limegreen = Color.FromHex("#00FF00");


            Label label = new Label
            {
                Text = "I was changed by ColorTypeConverter",
                IsVisible = true,
                Opacity = 0.75,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                // TextColor = Color.Blue,
                TextColor = limegreen,
                BackgroundColor = Color.FromRgb(255, 128, 128),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };





            (Content as StackLayout).Children.Insert(0, label);
        }
    }
}
