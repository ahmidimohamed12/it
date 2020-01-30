using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Health.model;
using System.Threading.Tasks;
using Xamarin.Forms;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts.Forms;

namespace Health
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<int> anner = new List<int>()
        {
            2010,2011,2012,2013,2014,2015,2016,2017,2018,2019
        };
        string m = "AT118r,M (MALE),175.0,42,81.1,28.1,16.4,12.2,4.2,20.2,44.6,44.6,34.7,57.4,26.5,24.9,0.92,3.4,40.2,1685,8,2242,199.6,108.2,199.6,120.3,108.3,105.2,101.8,94.9,94.5,28.7,23.4,17.6,14.4,12.4,10.2,4.2,3.5,16.2,8.1,77.5,57.3,35.2,28.8,25.0,18.5,20.0,10.0,0.90,0.80,8.1,16.2,1710,2008,37.9,46.3,51.5,63.0,48.6,59.4,A£@@A£@@@@@@1.7,-9.4,0.0,-9.4,74,319.4,333.2,24.9,273.1,274.8,279.5,292.1,20.3,237.1,238.7D8";
        string op = "None,ID,";
        List<mesure> n;
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

        IList<mesure> mas { get; set; }
        public MainPage()
        {
            InitializeComponent();
            desca();

            double twid = (int) Plugin.XamJam.Screen.CrossScreen.Current.Size.Width / 4;
            btnsearch.Clicked += (sender, e) =>
            {

                if (annmin.SelectedIndex > 0)
                {
                    srch.IsVisible = true;
                    effi.IsEnabled = false;
                    annmin.IsEnabled = false;
                    anmax.IsEnabled = false;
                    Device.StartTimer(TimeSpan.FromSeconds(4), () =>
                    {
                        activer();
                        return false;
                    });
                }
                
            };

            anner.Add(DateTime.Now.Year);


            Uri p = new Uri("https://cloud.heitzsystem.com/heitzfit/1000/api/sweb1000.png");
            Uri l = new Uri("https://www.flaticon.com/free-icon/actualize-arrows-couple-in-circle_46520");
            Uri o = new Uri("https://cloud.heitzsystem.com/heitzfit/1000/app//images/man-standing-back.png");
            Uri mr = new Uri("https://image.freepik.com/photos-gratuite/jeune-femme-active-formation-plein-air_23-2148381886.jpg");
            li.Source = ImageSource.FromUri(mr);
           // li.WidthRequest = Plugin.XamJam.Screen.CrossScreen.Current.Size.Width;
            im.Source = ImageSource.FromUri(o);
            anmax.ItemsSource = anner;
            annmin.ItemsSource = anner;

            var ty = Plugin.XamJam.Screen.CrossScreen.Current.Size.Width;

            var gridman = (ty - 10) / 3; 

            var cl1 = ty / 3;
            
            chrt.Chart = new Microcharts.DonutChart { Entries = en };
            string[] v = m.Split(',');
            mas = new List<mesure>();
            for (int i = 0;i< v.Length;i++)
            {
                var t = new mesure();
                t.code = v[i];
                mas.Add(t);
            }

            var list = (from a in mas
                    select a.code).ToList();

            txtcnt.Text = list.Count.ToString();
            ls.ItemsSource = list;
            BindingContext = this;

            annmin.SelectedIndexChanged += (sender, e) =>
            {
                Picker pi = (Picker)sender;
                int a = (int)pi.SelectedItem;

                List<int> vl = new List<int>();
                a++;
                for (int i = 0 ; i < DateTime.Now.Year;i++)
                {
                    vl.Add(a);
                    a += 1;
                    if (a == DateTime.Now.Year)
                        break;
                }
                anmax.ItemsSource = vl;
            };

            anmax.SelectedIndexChanged += (sender, e) =>
            {
                Picker po = (Picker)sender;
                int a = (int)po.SelectedItem;
                List<int> vl = new List<int>();

            };
            btn11.Clicked += (sender, e) =>
            {
                Uri u = new Uri("https://cloud.heitzsystem.com/heitzfit/1000/app//images/man-standing-back.png");
                im.Source = ImageSource.FromUri(u);
            };
            btn22.Clicked += (sender, e) =>
            {
                Uri u = new Uri("https://cloud.heitzsystem.com/heitzfit/1000/app//images/man-posing-back.png");
                im.Source = ImageSource.FromUri(u);
            };
            ls.ItemSelected += list_item_click;
        }
        private void desca()
        {
            ls.IsVisible = false;
            chrt.IsVisible = false;
          //  st1.IsVisible = false;
            lbldes.IsVisible = false;
            bu.IsVisible = false;
            gg.IsVisible = false;
            srch.IsVisible = false;
        }

        private void activer()
        {
           
            srch.IsVisible = false;
            ls.IsVisible = true;
            chrt.IsVisible = true;
           // st1.IsVisible = true;
            lbldes.IsVisible = true;
            bu.IsVisible = true;
            gg.IsVisible = true;
            effi.IsVisible = false;
        }

        private void list_item_click(object sender,EventArgs e)
        {
            ListView vl = (ListView)sender;
            string k =(string) vl.SelectedItem;
            DisplayAlert("hy",k.ToString(),"ok");
        }
    }
}
