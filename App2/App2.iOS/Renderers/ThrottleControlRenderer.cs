using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

using App2.iOS.Renderers;
using UIKit;
using CoreGraphics;

[assembly: ExportRenderer(typeof(Slider), typeof(ThrottleControlRenderer))]
namespace App2.iOS.Renderers
{
    public class ThrottleControlRenderer : SliderRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetThumbImage(UIImage.FromFile("throttle_thumb.png"), UIControlState.Normal);
                Control.TintColor = UIColor.FromRGB(217, 0, 0);
            }
        }
    }
}