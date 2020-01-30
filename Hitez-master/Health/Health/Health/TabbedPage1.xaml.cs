using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.XamJam.Screen;
using Entry = Microcharts.Entry;
using Xamarin.Forms;
using SkiaSharp;
using Xamarin.Forms.Xaml;

namespace Health
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
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
                Color = SKColor.Parse("#02cef2"),
                ValueLabel = "100",
                Label = ""
            }
        };
        List<int> anner = new List<int>()
        {
            2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020,2021
        };
        string m = "AT118rM,175.0,42,81.1,28.1,16.4,12.2,4.2,20.2,44.6,44.6,34.7,57.4,26.5,24.9,0.92,3.4,40.2,1685,8,2242,199.6,108.2,199.6,120.3,108.3,105.2,101.8,94.9,94.5,28.7,23.4,17.6,14.4,12.4,10.2,4.2,3.5,16.2,8.1,77.5,57.3,35.2,28.8,25.0,18.5,20.0,10.0,0.90,0.80,8.1,16.2,1710,2008,37.9,46.3,51.5,63.0,48.6,59.4,A£@@A£@@@@@@1.7,-9.4,0.0,-9.4,74,319.4,333.2,24.9,273.1,274.8,279.5,292.1,20.3,237.1,238.7D8";
        string op = "None,ID,";
        public TabbedPage1()
        {
            InitializeComponent();
            

            Uri p = new Uri("https://cloud.heitzsystem.com/heitzfit/1000/api/sweb1000.png");
            anmax.ItemsSource = anner;
            annmin.ItemsSource = anner;
            chrt.Chart = new Microcharts.RadialGaugeChart { Entries = en };

            List<string> v = m.Split(',').ToList();
            x.Text = v.Count.ToString();
            int cnt = v.Count;
            txtcnt.Text = cnt.ToString();
            var od = (from a in v
                          where a.Length <= 5
                          select a).ToList();
            ls.ItemsSource = v;
            imlgo.Source = ImageSource.FromUri(p);

           
        }
    }
}