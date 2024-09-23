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

namespace Ex1_InterfícieBàsica
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

        private void Botó1_Click(object sender, RoutedEventArgs e)
        {
            Etiqueta.Content = "Text canviat!";
        }

        private void Botó2_Click(object sender, RoutedEventArgs e)
        {
            Etiqueta.Content = "Hola, món!";
        }

    }
}