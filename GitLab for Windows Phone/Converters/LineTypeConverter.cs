using System;
using Windows.UI.Xaml.Data;
using GitLab_for_Windows_Phone.Models;

namespace GitLab_for_Windows_Phone.Converters
{
    public class LineTypeConverter: IValueConverter
    {
        public object AddedLineValue { get; set; }

        public object RemovedLineValue { get; set; }

        public object UntouchedLineValue { get; set; }

        public object AreaInfoLineValue { get; set; }


        #region IValueConverter Membres

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var type = (FileDiff.LineTypes) value;
            switch (type)
            {
                case FileDiff.LineTypes.Added:
                    return AddedLineValue;
                case FileDiff.LineTypes.AreaInfo:
                    return AreaInfoLineValue;
                case FileDiff.LineTypes.Removed:
                    return RemovedLineValue;
                case FileDiff.LineTypes.Untouched:
                default :
                    return UntouchedLineValue;

            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
