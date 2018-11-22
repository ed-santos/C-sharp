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
    /// Interaction logic for Pizza.xaml
    /// </summary>
    public partial class Pizza : Window
    {
        public static int counter = 0;
        public static int sizePrice = 0;
        public static int addOn = 0;
        

        public Pizza()
        {
            InitializeComponent();

            userNameTXT1.Content = MainWindow.name + " !";
        }

        public void addAddon()
        {
            Console.WriteLine("checked");

            counter++;

            if (counter > 3)
            {
                int extras = counter - 3;

                addOn = extras * 1;

            }
            else
            {
                addOn = 0;
            }

            totalLbl.Content = (sizePrice + addOn).ToString();
        }
        public void removeAddon()
        {
            counter--;

            if (counter > 3)
            {
                int extras = counter - 3;

                addOn = extras * 1;

            }
            else
            {
                addOn = 0;
            }

            totalLbl.Content = (sizePrice + addOn).ToString();
        }

        private void smallBtn_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 7;
            totalLbl.Content = sizePrice.ToString();

        }

        private void mediumBtn_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 9;
            totalLbl.Content = sizePrice.ToString();
        }

        private void largeBtn_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 11;
            totalLbl.Content = sizePrice.ToString();
        }

        private void xtraBtn_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 13;
            totalLbl.Content = sizePrice.ToString();
        }

        private void superThinBtn_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = sizePrice + 1;
            totalLbl.Content = sizePrice.ToString();
        }
        private void superThinBtn_UnChecked(object sender, RoutedEventArgs e)
        {
            sizePrice = sizePrice - 1;
            totalLbl.Content = sizePrice.ToString();
        }

        private void thinBtn_Checked(object sender, RoutedEventArgs e)
        {
            totalLbl.Content = sizePrice.ToString();
        }
        private void regularBtn_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = sizePrice+0;
            totalLbl.Content = sizePrice.ToString();
        }

        private void deepBtn_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = sizePrice + 1;
            totalLbl.Content = sizePrice.ToString();
        }
        private void deepBtn_UnChecked(object sender, RoutedEventArgs e)
        {
            sizePrice = sizePrice - 1;
            totalLbl.Content = sizePrice.ToString();
        }

        private void pepChk_Checked(object sender, RoutedEventArgs e)
        {
            if (pepChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void sausageChk_Checked(object sender, RoutedEventArgs e)
        {
            if (sausageChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void beefChk_Checked(object sender, RoutedEventArgs e)
        {
            if (beefChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void hamChk_Checked(object sender, RoutedEventArgs e)
        {
            if (hamChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void baconChk_Checked(object sender, RoutedEventArgs e)
        {
            if (baconChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void chickenChk_Checked(object sender, RoutedEventArgs e)
        {
            if (chickenChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void mushroomChk_Checked(object sender, RoutedEventArgs e)
        {
            if (mushroomChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void onionChk_Checked(object sender, RoutedEventArgs e)
        {
            if (onionChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void tomatoChk_Checked(object sender, RoutedEventArgs e)
        {
            if (tomatoChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void pineappleChk_Checked(object sender, RoutedEventArgs e)
        {
            if (pineappleChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void spinachChk_Checked(object sender, RoutedEventArgs e)
        {
            if (spinachChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void jalapenoChk_Checked(object sender, RoutedEventArgs e)
        {
            if (jalapenoChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void greenPepperChk_Checked(object sender, RoutedEventArgs e)
        {
            if (greenPepperChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void blackOlivesChk_Checked(object sender, RoutedEventArgs e)
        {
            if (blackOlivesChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void greenOlivesChk_Checked(object sender, RoutedEventArgs e)
        {
            if (greenOlivesChk.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }
        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            Checkout window = new Checkout();
            window.Show();
            this.Hide();
        }
    }
}
