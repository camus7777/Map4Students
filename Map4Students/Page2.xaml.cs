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

            SQLiteConnection conn = new SQLiteConnection("Data Source=TimeTabledb.sqlite;Version=3;");
            conn.Open();


            string sql = "select * from Timetable1 order by Day desc";
            SQLiteCommand command2 = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command2.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Week: " + reader["Week"] + "\tDay: " + reader["Day"] + "\tTutor: " + reader["Tutorial"] + "\tTutorial: " + reader["Tutorial_Room"] + "\tPeriod1: " + reader["P1"] + "\tPeriod1 Room: " + reader["P1_Room"] + "\tPeriod2: " + reader["P2"] + "\tPeriod2 Room: " + reader["P2_Room"] + "\tPeriod3: " + reader["P3"] + "\tPeriod3 Room: " + reader["P3_Room"] + "\tPeriod4: " + reader["P4"] + "\tPeriod4 Room: " + reader["P4_Room"] + "\tPeriod5: " + reader["P5"] + "\tPeriod5 Room: " + reader["P5_Room"] + "\tPeriod6: " + reader["P6"] + "\tPeriod6 Room: " + reader["P6_Room"]);

            
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
