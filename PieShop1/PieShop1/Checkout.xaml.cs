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
using System.Windows.Shapes;

namespace PieShop1
{
    /// <summary>
    /// Interaction logic for Checkout.xaml
    /// </summary>
    public partial class Checkout : Window
    {
        public static Double totalPr = 0;
        public static Double hstTotal = 0;
        public static Double piePr = 0;

   

        public Checkout()
        {
            InitializeComponent();

            userNameTXT2.Content = MainWindow.name + " !";

            piePr = Pizza.sizePrice;
            String.Format("{0:.##}", piePr);
            piePrice.Content = "$ " + piePr;

            hstTotal = (piePr * 13) / 100;
            String.Format("{0:.##}", hstTotal);
            hst.Content = "$ " + hstTotal;

            totalPr = Pizza.sizePrice + hstTotal;
            String.Format("{0:.##}", totalPr);
            totalPrice.Content = "$ " + totalPr;
        }

        private void Next2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you!");
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Pizza window = new Pizza();
            window.Show();
            this.Hide();
        }

        private void startOver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Hide();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
