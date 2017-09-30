using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Data;

namespace Zombicide.Converter
{
    [ValueConversion(typeof(Stream), typeof(Stream))]
    public class ImageStreamConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return DependencyProperty.UnsetValue;
            else return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }

    }
}