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

namespace Ventanillas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> list = new List<string> { "item1", "item2", "item3", "item4", "item5", "item6", "item7" };
            CB_Unidad.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if( sender == BT_Guardar)
            {
                Window1 w = new Window1();
                w.Show();
                Close();
            }
            else if( sender == BT_Cerrar)
            {
                Close();
            }
            else if ( sender == Clic)
            {
                MessageBox.Show("Elvis No Es Presley Ni Tampoco Crespo","¿Quién es elvis?");
            }
            else
            {
            MessageBox.Show("Estas en la unidad : " + CB_Unidad.SelectedItem.ToString());
            }
        }
    }
}
