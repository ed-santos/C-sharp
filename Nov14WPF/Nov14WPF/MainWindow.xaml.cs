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
using MySql.Data.MySqlClient;

namespace Nov14WPF
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

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            fName.Text = "";
            lName.Text = "";
            address.Text = "";
            phone.Text = "";
            //maleBtn.IsChecked = false;
            //femaleBtn.IsChecked = false;

        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            var fname = fName.Text;
            var lname = lName.Text;
            var add = address.Text;
            var ph = phone.Text;

            var gender = "";
            var emp = "";

            if (malebtn.IsChecked == true)
                gender = "male";

            if (femalebtn.IsChecked == true)
                gender = "female";

            /* if (fullTimebtn.IsChecked == true)
                 status = "fulltime";

             if (partTimebtn.IsChecked == true)
                 status = "parttime";*/

            if (fname == "" || lname == "" || ph == "" || add == "")
                MessageBox.Show("Please provide complete information" + gender, emp);
            else
                MessageBox.Show("Thank you for joining our story. We'll be in touch shortly!");


        

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=studentform;";
        string query = "INSERT INTO students(`id`, `firstName`, `lastName`,`gender`,`employement`, `address`,`phone`) VALUES (NULL, '" + fName + "', '" + lName + "', '" + gender + "', '" + emp + "', '" + add + "', '" + ph + "')";
        // Which could be translated manually to :
        // INSERT INTO user(`id`, `firstName`, `lastName`, `address`) VALUES (NULL, 'John', 'Doe', 'John Doe Villa')

        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

        MessageBox.Show("User succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
{
    Application.Current.MainWindow.Close();

}

        private void ListRecord_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();

            win2.Show();

            this.Hide();
        }
    }

}
