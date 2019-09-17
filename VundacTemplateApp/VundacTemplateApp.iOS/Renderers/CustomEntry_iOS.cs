using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using UIKit;
using VundacTemplateApp.Controls;
using VundacTemplateApp.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntry_iOS))]
namespace VundacTemplateApp.iOS.Renderers
{
    class CustomEntry_iOS : EntryRenderer
    {
        protected override UITextField CreateNativeControl()
        {
            return new PaddingTextField();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.VerticalAlignment = UIControlContentVerticalAlignment.Center;

                ResetPadding();
            }
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
            if (Element is CustomEntry entry && Control is PaddingTextField field)
            {
                var padding = entry.Padding;
                var left = (nfloat)padding.Left;
                var top = (nfloat)padding.Top;
                var right = (nfloat)padding.Right;
                var bottom = (nfloat)padding.Bottom;

                field.EdgeInsets = new UIEdgeInsets(top, left, bottom, right);
            }
        }
    }

    public class PaddingTextField : UITextField
    {
        public UIEdgeInsets EdgeInsets { get; set; }

        public PaddingTextField()
        {
            EdgeInsets = UIEdgeInsets.Zero;
        }
        public PaddingTextField(IntPtr intPtr) : base(intPtr)
        {
            EdgeInsets = UIEdgeInsets.Zero;
        }

        public override CGRect TextRect(CGRect forBounds)
        {
            return base.TextRect(InsetRect(forBounds, EdgeInsets));
        }

        public override CGRect EditingRect(CGRect forBounds)
        {
            return base.EditingRect(InsetRect(forBounds, EdgeInsets));
        }

        // Workaround until this method is available in Xamarin.iOS
        public static CGRect InsetRect(CGRect rect, UIEdgeInsets insets)
        {
            return new CGRect(rect.X + insets.Left,
                                   rect.Y + insets.Top,
                                   rect.Width - insets.Left - insets.Right,
                                   rect.Height - insets.Top - insets.Bottom);
        }
    }
}