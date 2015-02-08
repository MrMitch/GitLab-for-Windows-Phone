using System;
using Windows.UI.Xaml.Data;

namespace GitLab_for_Windows_Phone.Converters
{
    public class BooleanConverter : IValueConverter
    {
        public bool IsInverted { get; set; }

        public object TrueValue { get; set; }

        public object FalseValue { get; set; }

        #region IValueConverter Membres

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var b = System.Convert.ToBoolean(value);
            return IsInverted 
                ? (b ? FalseValue : TrueValue)
                : (b ? TrueValue : FalseValue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
