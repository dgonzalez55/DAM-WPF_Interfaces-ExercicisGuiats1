using Microsoft.Windows.Themes;
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

namespace Ex3_AutogenAdapt
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
            Etiqueta1.Content = "Text canviat!";
            Etiqueta2.Visibility = Visibility.Visible;

            // Prenem com a base l'estil per defecte del botó
            Style styleB2 = new Style(typeof(Button), Botó2.Style);

            // Establim el background per defecte
            styleB2.Setters.Add(new Setter(Button.BackgroundProperty, new SolidColorBrush(Colors.LightGreen)));

            // Crear un trigger per modificar el comportament MouseOver que manté el mateix color
            Trigger trigger = new Trigger{Property = Button.IsMouseOverProperty,Value = true};
            trigger.Setters.Add(new Setter(Button.BackgroundProperty, new SolidColorBrush(Colors.DarkGreen)));
            trigger.Setters.Add(new Setter(Button.BorderBrushProperty, new SolidColorBrush(Colors.LightGreen)));
            //Afegim el trigger a l'estil
            styleB2.Triggers.Add(trigger);

            //Aplicar l'estil al botó 2
            Botó2.Style = styleB2;
        }

        private void Botó2_Click(object sender, RoutedEventArgs e)
        {
            Etiqueta1.Content = "Hola, món!";
            Etiqueta2.Visibility = Visibility.Hidden;
            Botó2.ClearValue(Button.StyleProperty);
        }
    }
}