using AllLaunchCore;
using System;
using System.Globalization;

namespace AllLaunchWPF
{
    /// <summary>
    /// ApplicationPage type converted into an actual WPF page type
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture) => ((ApplicationPage)value) switch
        {
            ApplicationPage.LaunchListPage => new LaunchListPage(),
            _ => null
        };

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
