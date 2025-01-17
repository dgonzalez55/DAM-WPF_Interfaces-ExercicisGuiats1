﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex6_UIOrg
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string missatge = "Cal omplir tots els camps";
            if (NomTextBox.Text != "" && AdreçaTextBox.Text != "")
            {
                missatge = "Formulari Enviat!";
                NomTextBox.Clear();
                AdreçaTextBox.Clear();
            }
            CustomMessageBox.ShowMessageBox(this, missatge);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomMessageBox.ShowMessageBox(this, "A reveure");
            this.Close();
        }
    }
}