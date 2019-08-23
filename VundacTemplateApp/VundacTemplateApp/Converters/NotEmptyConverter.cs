using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace VundacTemplateApp.Converters
{
    public class NotEmptyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string str)
            {
                return String.IsNullOrEmpty(str);
            }
            else if (value is IEnumerable enumerable)
            {
                var item = enumerable.GetEnumerator();
                return !item.MoveNext();
            }
            else
            {
                throw new ArgumentException($"{nameof(NotEmptyConverter)} support only strings and collections");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
