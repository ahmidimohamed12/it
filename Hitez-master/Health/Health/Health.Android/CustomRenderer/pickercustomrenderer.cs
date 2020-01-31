using System;
using System.ComponentModel;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Health.controls;
using Health.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(Pickericons), typeof(Health.Droid.CustomRenderer.Pickercustomrenderer))]

namespace Health.Droid.CustomRenderer
{
    [Obsolete]
    public class Pickercustomrenderer : PickerRenderer
    {

		Pickericons element;

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            SetControlStyle();
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            SetControlStyle();
        }

        private void SetControlStyle()
        {
            if (Control != null)
            {
                Drawable imgDropDownArrow = Resources.GetDrawable(Resource.Drawable.and);
                imgDropDownArrow.SetBounds(5, 5, 5, 5);
                Control.SetCompoundDrawablesRelativeWithIntrinsicBounds(null, null, imgDropDownArrow, null);
            }
        }
    }
}
