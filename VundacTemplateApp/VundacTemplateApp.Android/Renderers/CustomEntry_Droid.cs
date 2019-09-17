using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VundacTemplateApp.Controls;
using VundacTemplateApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntry_Droid))]
namespace VundacTemplateApp.Droid.Renderers
{
    class CustomEntry_Droid : EntryRenderer
    {
        private double density => Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Density;

        public CustomEntry_Droid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.Background = null;
            }
            ResetPadding();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == nameof(Entry.FontSize) ||
                e.PropertyName == nameof(Entry.FontAttributes) ||
                e.PropertyName == nameof(Entry.FontFamily))
            {
                ResetPadding();
            }
        }

        private void ResetPadding()
        {
            if (Element is CustomEntry entry)
            {
                var left = (int)(entry.Padding.Left * density);
                var top = (int)(entry.Padding.Top * density);
                var right = (int)(entry.Padding.Right * density);
                var bottom = (int)(entry.Padding.Bottom * density);
                Control.SetPadding(left, top, right, bottom);
            }
        }
    }
}