using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Health
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            int n = 1;
            lblres.Text = "Mes Reservation ("+n.ToString()+")";

        }

        private void btn_calnd(object sender,EventArgs e)
        {

        }
    }
}
