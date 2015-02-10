using System;
using Windows.UI.Xaml.Data;
using GitLab_for_Windows_Phone.Models;

namespace GitLab_for_Windows_Phone.Converters
{
    public class DiffTypeConverter : IValueConverter
    {
        public object CreatedFileValue { get; set; }

        public object RemovedFileValue { get; set; }

        public object EditedFileValue { get; set; }

        #region Implementation of IValueConverter

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var type = (FileDiff.FileDiffTypes) value;
            switch (type)
            {
                case FileDiff.FileDiffTypes.Created:
                    return CreatedFileValue;
                case FileDiff.FileDiffTypes.Edited:
                    return EditedFileValue;
                case FileDiff.FileDiffTypes.Removed:
                default :
                    return RemovedFileValue;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
