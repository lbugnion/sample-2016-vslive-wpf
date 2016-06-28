using System.Windows;

namespace WpfGraphics
{
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello VS Live!!!");
        }
    }
}
