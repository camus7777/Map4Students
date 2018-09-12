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
using System.Data.SQLite;

namespace Map4Students
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

            SQLiteConnection conn = new SQLiteConnection("Data Source=TimeTabledb.db;Version=3;");
            conn.Open();


            conn.Close();
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            this.NavigationService.Navigate(page1);
        }

        private void Button3(object sender, RoutedEventArgs e)
        {
            MapPage mappage = new MapPage();
            this.NavigationService.Navigate(mappage);
        }
    }
}
