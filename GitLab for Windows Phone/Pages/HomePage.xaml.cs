using System;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d’élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkID=390556
using GitLab_for_Windows_Phone.Common;
using GitLab_for_Windows_Phone.DesignData;
using GitLab_for_Windows_Phone.Models;
using GitLab_for_Windows_Phone.Services;
using GitLab_for_Windows_Phone.ViewModels.Pages;
using Newtonsoft.Json;

namespace GitLab_for_Windows_Phone.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePageViewModel ViewModel { get; set; }

        private NavigationHelper _navigationHelper;
        public NavigationHelper NavigationHelper
        {
            get { return _navigationHelper; }
        }
        
        

        public HomePage()
        {
            ViewModel = new DesignHomePageViewModel();

            this.InitializeComponent();
            _navigationHelper = new NavigationHelper(this);
            _navigationHelper.LoadState += NavigationHelperOnLoadState;

            var statusBar = StatusBar.GetForCurrentView();
            statusBar.BackgroundOpacity = 0;
            statusBar.BackgroundColor = Colors.Transparent;
        }

        private async void NavigationHelperOnLoadState(object sender, LoadStateEventArgs loadStateEventArgs)
        {
            // temp
            var projectsFileUri = new Uri("ms-appx:///DesignData/samples/projects.json");
            var projectsFile = await StorageFile.GetFileFromApplicationUriAsync(projectsFileUri);
            var projectsJson = await FileIO.ReadTextAsync(projectsFile);
            var vm = JsonConvert.DeserializeObject<DesignHomePageViewModel>(projectsJson);

            ViewModel.Groups = vm.Groups;
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

        private void ProjectsListView_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var project = e.ClickedItem as Project;
            NavigationService.NavigateToProject(project.Id);
        }
    }
}
