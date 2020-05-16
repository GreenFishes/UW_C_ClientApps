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
using System.Text.RegularExpressions;

// C# Core Client Apps
// Homework Week4
// Charles Henry

namespace HomeworkWeek4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string mysubString = "";
        private bool firstTime = true;
        private bool isNumeric = false;

        public MainWindow()
        {
            InitializeComponent();
            Button1.IsEnabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button1.IsEnabled = false;
        }

        private void txtZipCode_TextChanged(object sender, RoutedEventArgs e)
        {
            string myString = txtZipCode.Text;


            if (firstTime)
            {
                var firstOne = myString.Substring(0);   //check if first char is a string
                int n;
                isNumeric = int.TryParse(firstOne, out n);
                firstTime = false;
            }


            if (myString.Length > 4)
            {

                if (myString.Length < 7) { mysubString = myString.Substring(5); }  //check for dash

                if (myString.Length > 5 && mysubString.ToString() == "-")
                {
                    if (myString.Length > 9)  // check for US Zip Code + 4

                        if (!Regex.Match(myString, @"^\d{5}(?:[-\s]\d{4})?$").Success)
                        {
                            MessageBox.Show("Please enter a valid zip code");
                            txtZipCode.Text = "";
                            mysubString = "";
                            firstTime = true;
                            isNumeric = false;
                            txtStatus1.Text = "";

                            Button1.IsEnabled = false;
                        }
                        else
                        { txtStatus1.Text = "American Zip Code +4"; }

                }
                else if (myString.Length < 6 && isNumeric) // check for US Zip Code
                {
                    if (!Regex.Match(myString, @"^[0-9]{5}$").Success)
                    {
                        MessageBox.Show("Please enter a valid zip code");
                        txtZipCode.Text = "";
                        mysubString = "";
                        firstTime = true;
                        isNumeric = false;
                        txtStatus1.Text = "";

                        Button1.IsEnabled = false;
                    }
                    else
                    {
                        Button1.IsEnabled = true;
                        txtStatus1.Text = "American Zip Code";

                    }
                }

                else if (myString.Length > 5 && !isNumeric) //check for Canadian Zip Code
                {
                    if (!Regex.Match(myString, @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$").Success)
                    {
                        MessageBox.Show("Please enter a valid zip code");
                        txtZipCode.Text = "";
                        mysubString = "";
                        firstTime = true;
                        isNumeric = false;
                        txtStatus1.Text = "";

                        Button1.IsEnabled = false;
                    }
                    else
                    {
                        Button1.IsEnabled = true;
                        txtStatus1.Text = "Canadian Zip Code";
                    }
                }

                else if (isNumeric)   //not Canadian Zip Code
                {
                    MessageBox.Show("Please enter a valid zip code");
                    txtZipCode.Text = "";
                    mysubString = "";
                    firstTime = true;
                    isNumeric = false;
                    txtStatus1.Text = "";

                    Button1.IsEnabled = false;
                }

            }



        }

        
    }


}

