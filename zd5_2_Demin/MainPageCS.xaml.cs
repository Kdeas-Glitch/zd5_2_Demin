using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;

namespace zd5_2_Demin
{
    public class MainPageCS : CarouselPage
    {
        public MainPageCS()
        {

            var styleSheet = StyleSheet.FromResource(
    resourcePath: "E:\\Xamarin\\zd5_2_Demin\\zd5_2_Demin\\mystyle.css",
    assembly: GetType().GetTypeInfo().Assembly
);

            // Применение стилей
            Resources.Add("mystyle", styleSheet);

            Thickness padding;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                case Device.Android:
                    padding = new Thickness(0, 40, 0, 0);
                    break;
                default:
                    padding = new Thickness();
                    break;
            }

            var redContentPage = new ContentPage
            {
                Padding = padding,
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "Red",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new BoxView {
                        StyleClass = new[] { "box-style" }
                    }
                }
                }
            };

            var colorBoxView = new BoxView
            {
                StyleClass = new[] { "box-style" }  // Все свойства теперь в CSS
            };
            colorBoxView.SetBinding(BoxView.ColorProperty, "Color");
            var greenContentPage = new ContentPage
            {
                Padding = padding,
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "Green",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        StyleClass=new [] { "label-style" }
                    },
                    new BoxView {
                        Color = Color.Green,
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand

                    }
                    
                }
                }
            };
            var blueContentPage = new ContentPage
            {
                Padding = padding,
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "Yellow",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new BoxView {
                        Color = Color.Yellow,
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
                }
            };

            Children.Add(redContentPage);
            Children.Add(greenContentPage);
            Children.Add(blueContentPage);
        }
    }
}
