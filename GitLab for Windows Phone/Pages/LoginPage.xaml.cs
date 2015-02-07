// Pour en savoir plus sur le modèle d’élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkID=390556
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using GitLab_for_Windows_Phone.ViewModels.Pages;

namespace GitLab_for_Windows_Phone.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPageViewModel ViewModel { get; set; }

        public LoginPage()
        {
            ViewModel = new LoginPageViewModel();
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d'événement décrivant la manière dont l'utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
