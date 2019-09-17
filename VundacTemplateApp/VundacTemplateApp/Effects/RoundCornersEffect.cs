using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace VundacTemplateApp.Effects
{
    public class RoundCornersEffect : RoutingEffect
    {
        public double CornerRadius { get; set; } = 0;

        public RoundCornersEffect() : 
            base("VundacTemplateApp.RoundCornersEffect") { }
    }
}
