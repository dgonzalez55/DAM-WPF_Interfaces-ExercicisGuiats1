using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex7_Multimedia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Play(object sender, RoutedEventArgs e)
        {
            VideoElement.Play();
        }

        private void Button_Pause(object sender, RoutedEventArgs e)
        {
            VideoElement.Pause();
        }

        private void Button_Aturar(object sender, RoutedEventArgs e)
        {
            VideoElement.Stop();
        }

        private void VideoElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            VideoElement.Position = TimeSpan.FromSeconds(1);
            VideoElement.Play();
        }
    }
}