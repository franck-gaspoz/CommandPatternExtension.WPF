using System;
using System.Globalization;
using System.Windows.Data;

namespace CommandPatternExtension.WPF.Converters
{
    public class NewCommandContextConverter
        : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var t = parameter as Type;
            if (t == null)
                throw new Exception($"object of type Type excepted, but getted: {parameter}");

            var o = Activator.CreateInstance(
                t,
                new object[] { value });

            return o;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
