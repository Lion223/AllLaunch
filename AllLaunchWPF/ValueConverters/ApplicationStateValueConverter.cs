using AllLaunchCore;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace AllLaunchWPF
{
    /// <summary>
    /// ApplicationStyle type converted into a color brush type
    /// </summary>
    public class ApplicationStateValueConverter : BaseValueConverter<ApplicationStateValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture) => ((ApplicationState)value) switch
        {
            ApplicationState.Inactive => (SolidColorBrush) Application.Current.FindResource("AppStateInactiveBrush"),
            ApplicationState.Running => (SolidColorBrush)Application.Current.FindResource("AppStateRunningBrush"),
            ApplicationState.Error => (SolidColorBrush)Application.Current.FindResource("AppStateErrorBrush"),
            _ => null
        };

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
