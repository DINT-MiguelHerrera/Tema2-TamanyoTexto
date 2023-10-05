using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_TamanyoTexto
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;  
            switch(radioButton.Tag.ToString())
            {
                case "botonPequeño":
                    textoCambiante.FontSize = 32;
                    break;
                case "botonMediano":
                    textoCambiante.FontSize = 48;
                    break;
                case "botonGrande":
                    textoCambiante.FontSize = 72;
                    break;
            }
        }
    }
}
