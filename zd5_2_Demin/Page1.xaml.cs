using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd5_2_Demin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : CarouselPage
    {
        public Page1()
        {
            InitializeComponent();
            if (Save.Ras == "ЕКТС")
            {
                Label_Choise.Text = "Екатеринбургский колледж транспортного строительства";
            }
            if (Save.Ras == "РМП")
            {
                Label_Choise.Text = "Разработка Мобильных Приложений";
            }
            if (Save.Ras == "РФ")
            {
                Label_Choise.Text = "Российская Федерация";
            }
        }
        private async void Clikc_Button1(object sender, System.EventArgs e)
        {
            if (button1.BackgroundColor == Color.Green)
            {
                button1.BackgroundColor = Color.White;
                button1.TextColor = Color.Black;
            }
            else
            {
                button1.BackgroundColor = Color.Green;
                button1.TextColor = Color.White;
            }
        }
        private async void Clikc_Button2(object sender, System.EventArgs e)
        {
            if (button2.BackgroundColor == Color.Green)
            {
                button2.BackgroundColor = Color.White;
                button2.TextColor = Color.Black;
            }
            else
            {
                button2.BackgroundColor = Color.Green;
                button2.TextColor = Color.White;
            }
        }
        private async void Clikc_Button3(object sender, System.EventArgs e)
        {
            if (button3.BackgroundColor == Color.Green)
            {
                button3.BackgroundColor = Color.White;
                button3.TextColor = Color.Black;
            }
            else
            {
                button3.BackgroundColor = Color.Green;
                button3.TextColor = Color.White;
            }
        }

        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (Switch_button.IsToggled)
            {
                On_label.IsVisible = true;
                Off_label.IsVisible = false;
            }
            else
            {
                On_label.IsVisible = false;
                Off_label.IsVisible = true;
            }
        }

        private void switcher_Toggled2(object sender, ToggledEventArgs e)
        {
            if (Switch_button2.IsToggled)
            {
                Yes_label.IsVisible = true;
                X_label.IsVisible = false;
            }
            else
            {
                Yes_label.IsVisible = false;
                X_label.IsVisible = true;
            }
        }
    }
}