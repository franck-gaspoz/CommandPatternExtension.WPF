using CommandPatternExtension.Command;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace CommandPatternExtension.WPF.Converters
{
    public class MultiCommandContextConverter
        : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null)
                return null;
            var cmdCtxList =
                values.Cast<CommandContextBase>()
                .ToList();
            return new MultiCommandContext(cmdCtxList);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
