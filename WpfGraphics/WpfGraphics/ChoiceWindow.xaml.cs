using System.Windows;
using System.Windows.Controls;

namespace WpfGraphics
{
    public partial class ChoiceWindow : Window
    {
        private Window _window;

        public ChoiceWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _window?.Close();

            var button = (Button)sender;

            if (button.Name == ImageBrushButton.Name)
            {
                _window = new FirstWindow();
            }
            else if (button.Name == VideoBrushButton.Name)
            {
                _window = new SecondWindow();
            }
            else if (button.Name == ClipButton.Name)
            {
                _window = new ThirdWindow();
            }
            else if (button.Name == MirrorButton.Name)
            {
                _window = new FourthWindow();
            }

            _window?.Show();
        }
    }
}
