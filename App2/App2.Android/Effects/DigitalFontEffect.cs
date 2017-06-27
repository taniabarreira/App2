using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Graphics;
using System.ComponentModel;
using App2;
using App2.Droid;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(App2.Droid.DigitalFontEffect), "FontEffect")]
namespace App2.Droid
{
    public class DigitalFontEffect : PlatformEffect
    {
        TextView control;
        protected override void OnAttached()
        {
            try
            {
                control = Control as TextView;
                Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Fonts/" + App2.DigitalFontEffect.GetFontFileName(Element) + ".ttf");
                control.Typeface = font;
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == App2.DigitalFontEffect.FontFileNameProperty.PropertyName)
            {
                Typeface font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, "Fonts/" + App2.DigitalFontEffect.GetFontFileName(Element) + ".ttf");
                control.Typeface = font;
            }
        }
    }
}