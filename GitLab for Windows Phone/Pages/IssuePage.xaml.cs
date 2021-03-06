﻿using System;
using System.Collections.Generic;
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
    public sealed partial class IssuePage : Page
    {
        private NavigationHelper _navigationHelper;
        public NavigationHelper NavigationHelper
        {
            get { return _navigationHelper; }
        }

        public IssuePageViewModel ViewModel { get; set; }

        public IssuePage()
        {
            ViewModel = new IssuePageViewModel();
            this.InitializeComponent();
            this._navigationHelper = new NavigationHelper(this);
            this._navigationHelper.LoadState += NavigationHelperOnLoadState;
        }

        private async void NavigationHelperOnLoadState(object sender, LoadStateEventArgs loadStateEventArgs)
        {
            // temp
            var projectsFileUri = new Uri("ms-appx:///DesignData/samples/issue.json");
            var projectsFile = await StorageFile.GetFileFromApplicationUriAsync(projectsFileUri);
            var projectsJson = await FileIO.ReadTextAsync(projectsFile);
            var vm = JsonConvert.DeserializeObject<IssuePageViewModel>(projectsJson);

            ViewModel.Issue = vm.Issue;

            foreach (var comment in vm.Comments)
            {
                ViewModel.Comments.Add(comment);
            }
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
    }
}
