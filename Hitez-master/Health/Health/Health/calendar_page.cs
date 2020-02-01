using System;

using Xamarin.Forms;

namespace Health
{
    public class calendar_page : ContentPage
    {
        public calendar_page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

