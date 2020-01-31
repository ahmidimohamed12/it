using Health.controls;
using PickerWithIcon.iOS;
using UIKit;
using Xamarin.Forms;
using System;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Pickericons), typeof(pickerRendcus))]
namespace PickerWithIcon.iOS
{
	public class pickerRendcus : PickerRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged(e);

			var element = (Pickericons)this.Element;

			if (this.Control != null && this.Element != null && !string.IsNullOrEmpty(element.Image))
			{
				var downarrow = UIImage.FromBundle(element.Image);
				Control.RightViewMode = UITextFieldViewMode.Always;
				Control.RightView = new UIImageView(downarrow);
			}
		}
	}
}