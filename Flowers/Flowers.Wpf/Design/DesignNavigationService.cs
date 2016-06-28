using GalaSoft.MvvmLight.Views;

namespace Flowers.Wpf.Design
{
    /// <summary>
    /// This class is only here to avoid errors at design time.
    /// </summary>
    public class DesignNavigationService : INavigationService
    {
        public string CurrentPageKey
        {
            get
            {
                return null;
            }
        }

        public void GoBack()
        {
            // Do nothing
        }

        public void NavigateTo(string pageKey)
        {
            // Do nothing
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            // Do nothing
        }
    }
}