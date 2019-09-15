using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using VundacTemplateApp.Effects;
using VundacTemplateApp.iOS.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName(nameof(VundacTemplateApp))]
[assembly: ExportEffect(typeof(RoundCornersEffect), nameof(RoundCornersEffect_iOS))]
namespace VundacTemplateApp.iOS.Effects
{
    class RoundCornersEffect_iOS : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var effect = Element.Effects.FirstOrDefault(x => x.GetType() == typeof(RoundCornersEffect)) as RoundCornersEffect;
                var radius = effect?.CornerRadius;

                if (Control != null)
                {
                    Control.Layer.CornerRadius = (nfloat)radius;
                }
                if (Container != null)
                {
                    Container.Layer.CornerRadius = (nfloat)radius;
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