using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;

namespace WpfVsUniv.Univ
{
    public sealed partial class MainPage
    {
        private Storyboard _sbd;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SubmitClick(object sender, RoutedEventArgs e)
        {
            if (_sbd == null)
            {
                _sbd = (Storyboard)Resources["BallStoryboard"];
            }

            _sbd.Stop();
            _sbd.Begin();
        }
    }
}
