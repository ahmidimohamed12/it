using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;
using SkiaSharp;


namespace Health
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class chart : ContentPage
    {
        List<Entry> en = new List<Entry>()
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#050608"),
                ValueLabel = "100",
                Label = "",
            },
             new Entry(100)
            {
                Color = SKColor.Parse("#00f700"),
                ValueLabel = "100",
                Label = ""
            },
              new Entry(200)
            {
                Color = SKColor.Parse("#00f700"),
                ValueLabel = "100",
                Label = ""
            }
        };
        public chart()
        {
            InitializeComponent();
           

        }
    }
}