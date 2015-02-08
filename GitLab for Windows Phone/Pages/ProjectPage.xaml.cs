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
using GitLab_for_Windows_Phone.DesignData;
using GitLab_for_Windows_Phone.ViewModels.Pages;
using Newtonsoft.Json;

namespace GitLab_for_Windows_Phone.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class ProjectPage : Page
    {
        private NavigationHelper _navigationHelper;
        public NavigationHelper NavigationHelper
        {
            get { return _navigationHelper; }
        }

        public ProjectPageViewModel ViewModel { get; set; }

        public ProjectPage()
        {
            ViewModel = new ProjectPageViewModel();

            this.InitializeComponent();
            _navigationHelper = new NavigationHelper(this);
            _navigationHelper.LoadState += NavigationHelperOnLoadState;
        }

        private async void NavigationHelperOnLoadState(object sender, LoadStateEventArgs loadStateEventArgs)
        {
            // temp
            var projectsFileUri = new Uri("ms-appx:///DesignData/samples/project.json");
            var projectsFile = await StorageFile.GetFileFromApplicationUriAsync(projectsFileUri);
            var projectsJson = await FileIO.ReadTextAsync(projectsFile);
            var vm = JsonConvert.DeserializeObject<ProjectPageViewModel>(projectsJson);

            foreach (var commit in vm.Commits)
            {
                ViewModel.Commits.Add(commit);
            }

            foreach (var branch in vm.Branches)
            {
                ViewModel.Branches.Add(branch);
            }
            
            foreach (var openedIssue in vm.OpenedIssues)
            {
                ViewModel.OpenedIssues.Add(openedIssue);
            }

            foreach (var closedIssue in vm.ClosedIssues)
            {
                ViewModel.ClosedIssues.Add(closedIssue);
            }

            ViewModel.SelectedBranch = ViewModel.Branches.FirstOrDefault(b => b.Name == "develop");
            ViewModel.Project = vm.Project;
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
