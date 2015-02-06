using Windows.Foundation.Collections;
using Windows.Storage;

namespace GitLab_for_Windows_Phone.Utils
{
    public static class SettingsHelper
    {
        public static IPropertySet Local
        {
            get { return ApplicationData.Current.LocalSettings.Values; }
        }

        public static IPropertySet Roaming
        {
            get { return ApplicationData.Current.RoamingSettings.Values; }
        }
    }
}
