using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VundacTemplateApp.Controls
{
    public class CustomEntry : Entry
    {
        #region BindableProperties
        public BindableProperty PaddingProperty = BindableProperty.Create(
            nameof(Padding),
            typeof(Thickness),
            typeof(CustomEntry),
            default(Thickness),
            BindingMode.OneWay);
        public Thickness Padding
        {
            get => (Thickness)GetValue(PaddingProperty);
            set => SetValue(PaddingProperty, value);
        }

        #endregion
    }
}
