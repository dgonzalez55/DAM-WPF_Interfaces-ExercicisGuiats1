using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Ex6_UIOrg
{
    public class CustomMessageBox: Window
    {
        public static void ShowMessageBox(Window parent, string missatge)
        {
            CustomMessageBox msgBox = new CustomMessageBox();

            msgBox.Width = 200;
            msgBox.Height = 120;
            //Centered in parent
            msgBox.Left = parent.Left + (parent.Width - msgBox.Width) / 2;
            msgBox.Top = parent.Top + (parent.Height - msgBox.Height) / 2;
            msgBox.Title = "Missatge";
            //Creem Text Informatiu
            TextBlock textBlock = new TextBlock();
            textBlock.Text = missatge;
            textBlock.Margin = new Thickness(10);
            //Creem Botó de Tancar
            Button button = new Button();
            button.Content = "Ok";
            button.Margin = new Thickness(10);
            button.Click += (sender, e) => msgBox.Close();
            //Afegim els controls al StackPanel
            msgBox.Content = new StackPanel() { Children = { textBlock, button } };

            msgBox.ShowDialog();
        }
    }
}
