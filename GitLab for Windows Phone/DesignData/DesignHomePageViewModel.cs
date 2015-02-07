using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using GitLab_for_Windows_Phone.Models;
using GitLab_for_Windows_Phone.ViewModels.Pages;
using Newtonsoft.Json;

namespace GitLab_for_Windows_Phone.DesignData
{
    public class DesignHomePageViewModel : HomePageViewModel
    {
        #region Overrides of HomePageViewModel

        public override async Task<IEnumerable<Project>> RetrieveProjects()
        {
            var projectsFileUri = new Uri("ms-appx:///DesignData/samples/projects.json");
            var projectsFile = await StorageFile.GetFileFromApplicationUriAsync(projectsFileUri);
            var projectsJson = await FileIO.ReadTextAsync(projectsFile);
            return JsonConvert.DeserializeObject<Project[]>(projectsJson);
        }

        #endregion
    }
}
