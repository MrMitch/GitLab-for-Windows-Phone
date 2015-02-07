using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using GitLab_for_Windows_Phone.Pages;

namespace GitLab_for_Windows_Phone.Services
{
    public class NavigationService
    {
        private static NavigationService Service { get; set; }

        private Frame Frame { get; set; }
        
        private NavigationService(Frame frame)
        {
            Frame = frame;
        }

        public static void RegisterFrame(Frame frame)
        {
            if (frame == null)
            {
                throw new ArgumentNullException("frame");
            }

            if (Service != null)
            {
                throw new InvalidOperationException("A frame has already registered");
            }

            Service = new NavigationService(frame);
        }

        public static bool NavigateToHome()
        {
            return Service.Frame.Navigate(typeof (HomePage));
        }

        public static bool NavigateToProject(int projectId)
        {
            return Service.Frame.Navigate(typeof (ProjectPage), projectId);
        }
    }
}
