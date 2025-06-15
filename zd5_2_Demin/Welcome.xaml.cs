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
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
            picker.SelectedItem = "ЕКТС";
        }
        private async void OnButtonClicked(object sender, System.EventArgs e)
        {
            
            if (User_Name.Text != ""&&Password.Text!=""&& picker.SelectedItem.ToString()!="")
            {
                Save.name = User_Name.Text;
                Save.Ras = picker.SelectedItem.ToString();
                await Navigation.PushModalAsync(new Page1());
            }
            else
            {
                DisplayAlert("Ошибка", "Введены не все данные", "OK");
            }
        }
    }
}