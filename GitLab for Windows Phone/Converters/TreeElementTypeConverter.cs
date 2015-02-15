using System;
using Windows.UI.Xaml.Data;
using GitLab_for_Windows_Phone.Models;

namespace GitLab_for_Windows_Phone.Converters
{
    public class TreeElementTypeConverter : IValueConverter
    {
        public object FolderValue { get; set; }

        public object FileValue { get; set; }

        public object UnknownValue { get; set; }

        #region IValueConverter Membres

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var type = (TreeElement.TreeElementTypes) value;

            switch (type)
            {
                case TreeElement.TreeElementTypes.Folder:
                    return FolderValue;
                case TreeElement.TreeElementTypes.File:
                    return FileValue;
                case TreeElement.TreeElementTypes.Unknow:
                default :
                    return UnknownValue;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
