using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VundacTemplateApp.Effects
{
    public class RoundCornersEffect : RoutingEffect
    {
        public double CornerRadius { get; set; } = 0;

        protected RoundCornersEffect() : base(nameof(RoundCornersEffect)) { }
    }
}
