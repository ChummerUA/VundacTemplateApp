using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using $safeprojectname$.Effects;
using $ext_safeprojectname$.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("$ext_safeprojectname$")]
[assembly: ExportEffect(typeof(RoundCornersEffect_Droid), "RoundCornersEffect")]
namespace VundacTemplateApp.Droid.Effects
{
    public class RoundCornersEffect_Droid : PlatformEffect
    {
        private double density => Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Density;

        protected override void OnAttached()
        {
            try
            {
                var effect = Element.Effects.FirstOrDefault(x => x.GetType() == typeof(RoundCornersEffect)) as RoundCornersEffect;
                var radius = effect?.CornerRadius;

                var draw = new GradientDrawable();
                draw.SetCornerRadius((float)(radius * density));
                draw.SetColor((Element as VisualElement).BackgroundColor.ToAndroid());

                if(Control != null)
                {
                    Control.Background = draw;
                }
                if(Container != null)
                {
                    Container.Background = draw;
                }
            }
            catch { }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}