using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;

namespace AllLaunchWPF
{
    class VisibilityValueConverter : BaseValueConverter<VisibilityValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture) => ((bool)value) switch
        {
            true => Visibility.Visible,
            false => Visibility.Hidden
        };

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
