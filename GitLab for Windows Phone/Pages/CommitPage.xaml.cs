using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d’élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkID=390556
using GitLab_for_Windows_Phone.Common;
using GitLab_for_Windows_Phone.ViewModels.Pages;
using Newtonsoft.Json;

namespace GitLab_for_Windows_Phone.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class CommitPage : Page
    {
        private NavigationHelper _navigationHelper;
        public NavigationHelper NavigationHelper
        {
            get { return _navigationHelper; }
        }

        public CommitPageViewModel ViewModel { get; set; }
        
        public CommitPage()
        {
            ViewModel = new CommitPageViewModel();
            this.InitializeComponent();
            this._navigationHelper = new NavigationHelper(this);
            this._navigationHelper.LoadState += NavigationHelperOnLoadState;
        }

        private async void NavigationHelperOnLoadState(object sender, LoadStateEventArgs loadStateEventArgs)
        {
            // temp
            var projectsFileUri = new Uri("ms-appx:///DesignData/samples/commit.json");
            var projectsFile = await StorageFile.GetFileFromApplicationUriAsync(projectsFileUri);
            var projectsJson = await FileIO.ReadTextAsync(projectsFile);
            var vm = JsonConvert.DeserializeObject<CommitPageViewModel>(projectsJson);

            ViewModel.Commit = vm.Commit;
            ViewModel.Diffs = vm.Diffs;
        }
        
        #region Inscription de NavigationHelper

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void FrameworkElement_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Height > Double.Epsilon && e.NewSize.Width > Double.Epsilon)
            {
                DiffsItemsControl.SizeChanged -= FrameworkElement_OnSizeChanged;

                LoadingProgressRing.IsActive = false;
                HeaderStackPanel.Visibility = Visibility.Visible;
                LoadingProgressRing.Visibility = Visibility.Collapsed;
            }
        }
    }
}
