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

namespace PieShop1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //creating a global variable
        public static String name = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Next1_Click(object sender, RoutedEventArgs e)
        {
            //setting value for global variable
            name = userName.Text;

            if (userName.Text == string.Empty)
            {
                MessageBox.Show("Please enter your name!");
                return;
            }
            else
            {
                Pizza window = new Pizza();
                window.Show();
                this.Hide();
            }
        }
    }
}
