using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VundacTemplateApp.Controls;
using VundacTemplateApp.Droid.Renderers.Visual;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryRenderer_Droid), new[] { typeof(VundacVisual) })]
namespace VundacTemplateApp.Droid.Renderers.Visual
{
    public class EntryRenderer_Droid : EntryRenderer
    {
        public EntryRenderer_Droid(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.Background = null;
            Control.SetPadding(0, 0, 0, 0);
        }
    }
}