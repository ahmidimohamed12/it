using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Health
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class debute : ContentPage
    {
        public debute()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(5),()=> {
                Navigation.PushModalAsync(new MainPage());
                return false;
            });
        }
    }
}