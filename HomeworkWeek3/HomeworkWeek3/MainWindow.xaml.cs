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
using System.ComponentModel;

namespace HomeworkWeek3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
                InitializeComponent();
                var users = new List<HomeworkWeek3.Models.User>();

                users.Add(new Models.User { Name = "Dave", Password = "1DavePwd" });
                users.Add(new Models.User { Name = "Steve", Password = "3StevePwd" });
                users.Add(new Models.User { Name = "Lisa", Password = "2LisaPwd" });

                uxList.ItemsSource = users;
        }

        void GridViewColumnHeaderClickedHandler(object sender,
                                                 RoutedEventArgs e)
        {
                string colName = e.OriginalSource.ToString();

                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);

           // MessageBox.Show(colName.Substring(46, 4));

                if (colName.Substring(46, 4) == "Name")
                { view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending)); }
                else if (colName.Substring(46, 4) == "Pass")
                { view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Ascending)); }

        }
    }
}

