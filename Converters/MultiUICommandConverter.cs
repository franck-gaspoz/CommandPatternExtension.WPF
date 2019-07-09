using CommandPatternExtension.WPF.Command;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;

namespace CommandPatternExtension.WPF.Converters
{
    public class MultiUICommandConverter
        : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var cmdList =
                values.Cast<ICommand>()
                .ToList();
            return new MultiUICommand(cmdList);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
