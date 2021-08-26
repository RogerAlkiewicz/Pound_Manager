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

namespace Pound_02
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

        private void ButtonAddPet_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPet.Text))
            {
                Pets.Items.Add(txtPet.Text);
                txtPet.Clear();
            }
        }

        private void ButtonDelPet_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= Pets.Items.Count - 1; i++)
                if (Pets.Items[i].Equals(txtPet.Text))
                {
                    Pets.Items.Remove(Pets.Items[i]);
                    break;
                }
        }
    }
}
