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
using System.Diagnostics;

// C# CORE CLIENT APPS
// Homework Week 5
// Charles Henry

namespace HomeworkWeek5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        string[] col1 = { null, null, null }; //column 1
        string[] col2 = { null, null, null }; //column 2
        string[] col3 = { null, null, null }; //column 3

        string[] row1 = { null, null, null }; // row 1
        string[] row2 = { null, null, null }; // row 2
        string[] row3 = { null, null, null }; // row 3

        string[] diag1 = { null, null, null }; // diagonal 1
        string[] diag2 = { null, null, null }; // diagonal 2

        string currentPlayer = 'o'.ToString();


        Boolean bol_X_Col1 = false;
        Boolean bol_X_Col2 = false;
        Boolean bol_X_Col3 = false;

        Boolean bol_X_Row1 = false;
        Boolean bol_X_Row2 = false;
        Boolean bol_X_Row3 = false;

        Boolean bol_X_Diag1 = false;
        Boolean bol_X_Diag2 = false;

        Boolean bol_O_Col1 = false;
        Boolean bol_O_Col2 = false;
        Boolean bol_O_Col3 = false;

        Boolean bol_O_Row1 = false;
        Boolean bol_O_Row2 = false;
        Boolean bol_O_Row3 = false;

        Boolean bol_O_Diag1 = false;
        Boolean bol_O_Diag2 = false;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void declareWinner(string strWinner)

        {

            foreach (UIElement control in this.uxGrid.Children)
            {

                Button aButton = (Button)control;
                aButton.IsEnabled = false;

            }


            if (strWinner.ToString() == "x".ToString()) { MessageBox.Show("X is the Winner"); }
            else if (strWinner.ToString() == "o".ToString()) { MessageBox.Show("O is the Winner"); }


        }
        private void resetAll()

        {
            bol_X_Col1 = false;
            bol_X_Col2 = false;
            bol_X_Col3 = false;

            bol_X_Row1 = false;
            bol_X_Row2 = false;
            bol_X_Row3 = false;

            bol_X_Diag1 = false;
            bol_X_Diag2 = false;

            bol_O_Col1 = false;
            bol_O_Col2 = false;
            bol_O_Col3 = false;

            bol_O_Row1 = false;
            bol_O_Row2 = false;
            bol_O_Row3 = false;

            bol_O_Diag1 = false;
            bol_O_Diag2 = false;

            for (int i = 0; i < col1.Length; i++)
            {
                col1[i] = "";
            }


            for (int i = 0; i < col2.Length; i++)
            {
                col2[i] = "";
            }

            for (int i = 0; i < col3.Length; i++)
            {
                col3[i] = "";
            }

            for (int i = 0; i < row1.Length; i++)
            {
                row1[i] = "";
            }

            for (int i = 0; i < row2.Length; i++)
            {
                row2[i] = "";
            }

            for (int i = 0; i < row3.Length; i++)
            {
                row3[i] = "";
            }

            for (int i = 0; i < diag1.Length; i++)
            {
                diag1[i] = "";
            }


            for (int i = 0; i < diag2.Length; i++)
            {
                diag2[i] = "";
            }

            currentPlayer = 'o'.ToString();

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button myButton = (Button)sender;

            if (myButton.Content == null || myButton.Content.ToString().Length < 1)

            {
                string myTag = myButton.Tag.ToString();

                if (currentPlayer == 'o'.ToString())
                { currentPlayer = 'x'.ToString(); }
                else
                { currentPlayer = 'o'.ToString(); }

                myButton.Content = currentPlayer.ToString();

                switch (myTag)
                {
                    case "0,0":
                        //  MessageBox.Show("you picked: 0,0");
                        col1[0] = currentPlayer.ToString();
                        row1[0] = currentPlayer.ToString();
                        diag1[0] = currentPlayer.ToString();
                        break;
                    case "0,1":
                        //  MessageBox.Show("you picked: 0,1");
                        col2[0] = currentPlayer.ToString();
                        row1[1] = currentPlayer.ToString();
                        break;
                    case "0,2":
                        // MessageBox.Show("you picked: 0,2");
                        col3[0] = currentPlayer.ToString();
                        row1[2] = currentPlayer.ToString();
                        diag2[0] = currentPlayer.ToString();
                        break;
                    case "1,0":
                        //  MessageBox.Show("you picked: 1,0");
                        col1[1] = currentPlayer.ToString();
                        row2[0] = currentPlayer.ToString();
                        break;
                    case "1,1":
                        //  MessageBox.Show("you picked: 1,1");
                        col2[1] = currentPlayer.ToString();
                        row2[1] = currentPlayer.ToString();
                        diag1[1] = currentPlayer.ToString();
                        diag2[1] = currentPlayer.ToString();
                        break;
                    case "1,2":
                        // MessageBox.Show("you picked: 1,2");
                        col3[1] = currentPlayer.ToString();
                        row2[2] = currentPlayer.ToString();
                        break;
                    case "2,0":
                        //   MessageBox.Show("you picked: 2,0");
                        col1[2] = currentPlayer.ToString();
                        row3[0] = currentPlayer.ToString();
                        diag2[2] = currentPlayer.ToString();
                        break;
                    case "2,1":
                        //  MessageBox.Show("you picked: 2,1");
                        col2[2] = currentPlayer.ToString();
                        row3[1] = currentPlayer.ToString();
                        break;
                    case "2,2":
                        //  MessageBox.Show("you picked: 2,2");
                        col3[2] = currentPlayer.ToString();
                        row3[2] = currentPlayer.ToString();
                        diag1[2] = currentPlayer.ToString();
                        break;
                }


                int int_X_Col1 = 0;
                int int_X_Col2 = 0;
                int int_X_Col3 = 0;

                int int_X_Row1 = 0;
                int int_X_Row2 = 0;
                int int_X_Row3 = 0;

                int int_X_Diag1 = 0;
                int int_X_Diag2 = 0;

                int int_O_Col1 = 0;
                int int_O_Col2 = 0;
                int int_O_Col3 = 0;

                int int_O_Row1 = 0;
                int int_O_Row2 = 0;
                int int_O_Row3 = 0;

                int int_O_Diag1 = 0;
                int int_O_Diag2 = 0;

             
                for (int i = 0; i < col1.Length; i++)
                {
                    if (col1[i] == 'x'.ToString())
                    { int_X_Col1 = int_X_Col1 + 1; }

                    if (col1[i] == 'o'.ToString())
                    { int_O_Col1 = int_O_Col1 + 1; }
                }

                if (int_X_Col1 == 3) { bol_X_Col1 = true; }
                if (int_O_Col1 == 3) { bol_O_Col1 = true; }

              
                for (int i = 0; i < col2.Length; i++)
                {
                    if (col2[i] == 'x'.ToString())
                    { int_X_Col2 = int_X_Col2 + 1; }

                    if (col2[i] == 'o'.ToString())
                    { int_O_Col2 = int_O_Col2 + 1; }
                }

                if (int_X_Col2 == 3) { bol_X_Col2 = true; }
                if (int_O_Col2 == 3) { bol_O_Col2 = true; }

              

                for (int i = 0; i < col3.Length; i++)
                {
                    if (col3[i] == 'x'.ToString())
                    { int_X_Col3 = int_X_Col3 + 1; }

                    if (col3[i] == 'o'.ToString())
                    { int_O_Col3 = int_O_Col3 + 1; }
                }

                if (int_X_Col3 == 3) { bol_X_Col3 = true; }
                if (int_O_Col3 == 3) { bol_O_Col3 = true; }

              

                for (int i = 0; i < row1.Length; i++)
                {
                    if (row1[i] == 'x'.ToString())
                    { int_X_Row1 = int_X_Row1 + 1; }

                    if (row1[i] == 'o'.ToString())
                    { int_O_Row1 = int_O_Row1 + 1; }
                }

                if (int_X_Row1 == 3) { bol_X_Row1 = true; }
                if (int_O_Row1 == 3) { bol_O_Row1 = true; }

              


                for (int i = 0; i < row2.Length; i++)
                {
                    if (row2[i] == 'x'.ToString())
                    { int_X_Row2 = int_X_Row2 + 1; }

                    if (row2[i] == 'o'.ToString())
                    { int_O_Row2 = int_O_Row2 + 1; }
                }

                if (int_X_Row2 == 3) { bol_X_Row2 = true; }
                if (int_O_Row2 == 3) { bol_O_Row2 = true; }

               


                for (int i = 0; i < row3.Length; i++)
                {
                    if (row3[i] == 'x'.ToString())
                    { int_X_Row3 = int_X_Row3 + 1; }

                    if (row3[i] == 'o'.ToString())
                    { int_O_Row3 = int_O_Row3 + 1; }
                }

                if (int_X_Row3 == 3) { bol_X_Row3 = true; }
                if (int_O_Row3 == 3) { bol_O_Row3 = true; }

              

                for (int i = 0; i < diag1.Length; i++)
                {
                    if (diag1[i] == 'x'.ToString())
                    { int_X_Diag1 = int_X_Diag1 + 1; }

                    if (diag1[i] == 'o'.ToString())
                    { int_O_Diag1 = int_O_Diag1 + 1; }
                }

                if (int_X_Diag1 == 3) { bol_X_Diag1 = true; }
                if (int_O_Diag1 == 3) { bol_O_Diag1 = true; }

               

                for (int i = 0; i < diag2.Length; i++)
                {
                    if (diag2[i] == 'x'.ToString())
                    { int_X_Diag2 = int_X_Diag2 + 1; }

                    if (diag2[i] == 'o'.ToString())
                    { int_O_Diag2 = int_O_Diag2 + 1; }
                }

                if (int_X_Diag2 == 3) { bol_X_Diag2 = true; }
                if (int_O_Diag2 == 3) { bol_O_Diag2 = true; }

                
                if (bol_X_Col1 || bol_X_Col2 || bol_X_Col3 || bol_X_Row1 || bol_X_Row2 || bol_X_Row3 || bol_X_Diag1 || bol_X_Diag2)
                { declareWinner("x"); }
                else if (bol_O_Col1 || bol_O_Col2 || bol_O_Col3 || bol_O_Row1 || bol_O_Row2 || bol_O_Row3 || bol_O_Diag1 || bol_O_Diag2)
                { declareWinner("o"); }

            }   //valid button selected
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {

            foreach (UIElement control in this.uxGrid.Children)
            {

                Button aButton = (Button)control;
                aButton.IsEnabled = true;
                aButton.Content = "";

            }

            resetAll();

        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
          
            this.Close();
        }

    }
}
