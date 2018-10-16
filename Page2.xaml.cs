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

            //Week A, Monday
            SQLiteCommand AA1 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day1T = AA1.ExecuteReader();
            SQLiteCommand BA1 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day1P1 = BA1.ExecuteReader();
            SQLiteCommand CA1 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day1P2 = CA1.ExecuteReader();
            SQLiteCommand DA1 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day1P3 = DA1.ExecuteReader();
            SQLiteCommand EA1 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day1P4 = EA1.ExecuteReader();
            SQLiteCommand FA1 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day1P5 = FA1.ExecuteReader();
            SQLiteCommand GA1 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day1P6 = GA1.ExecuteReader();
            while (Day1T.Read())
                AA.Content = Day1T["Tutorial_statement"];
            while(Day1P1.Read())
                BA.Content = Day1P1["P1_statement"];
            while(Day1P2.Read())
                CA.Content = Day1P2["P2_statement"];
            while (Day1P3.Read())
                DA.Content = Day1P3["P3_statement"];
            while (Day1P4.Read())
                EA.Content = Day1P4["P4_statement"];
            while (Day1P5.Read())
                FA.Content = Day1P5["P5_statement"];
            while (Day1P6.Read())
                GA.Content = Day1P6["P6_statement"];
            //Week A, Tuesday
            SQLiteCommand AB2 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day2T = AB2.ExecuteReader();
            SQLiteCommand BB2 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day2P1 = BB2.ExecuteReader();
            SQLiteCommand CB2 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day2P2 = CB2.ExecuteReader();
            SQLiteCommand DB2 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day2P3 = DB2.ExecuteReader();
            SQLiteCommand EB2 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day2P4 = EB2.ExecuteReader();
            SQLiteCommand FB2 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day2P5 = FB2.ExecuteReader();
            SQLiteCommand GB2 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day2P6 = GB2.ExecuteReader();
            while (Day2T.Read())
                AB.Content = Day2T["Tutorial_statement"];
            while (Day2P1.Read())
                BB.Content = Day2P1["P1_statement"];
            while (Day2P2.Read())
                CB.Content = Day2P2["P2_statement"];
            while (Day2P3.Read())
                DB.Content = Day2P3["P3_statement"];
            while (Day2P4.Read())
                EB.Content = Day2P4["P4_statement"];
            while (Day2P5.Read())
                FB.Content = Day2P5["P5_statement"];
            while (Day2P6.Read())
                GB.Content = Day2P6["P6_statement"];
            //Week A, Wednesday
            SQLiteCommand AC3 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day3T = AC3.ExecuteReader();
            SQLiteCommand BC3 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day3P1 = BC3.ExecuteReader();
            SQLiteCommand CC3 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day3P2 = CC3.ExecuteReader();
            SQLiteCommand DC3 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day3P3 = DC3.ExecuteReader();
            SQLiteCommand EC3 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day3P4 = EC3.ExecuteReader();
            SQLiteCommand FC3 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day3P5 = FC3.ExecuteReader();
            SQLiteCommand GC3 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day3P6 = GC3.ExecuteReader();
            while (Day3T.Read())
                AC.Content = Day3T["Tutorial_statement"];
            while (Day3P1.Read())
                BC.Content = Day3P1["P1_statement"];
            while (Day3P2.Read())
                CC.Content = Day3P2["P2_statement"];
            while (Day3P3.Read())
                DC.Content = Day3P3["P3_statement"];
            while (Day3P4.Read())
                EC.Content = Day3P4["P4_statement"];
            while (Day3P5.Read())
                FC.Content = Day3P5["P5_statement"];
            while (Day3P6.Read())
                GC.Content = Day3P6["P6_statement"];

            //Week A, Thursday
            SQLiteCommand AD4 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day4T = AD4.ExecuteReader();
            SQLiteCommand BD4 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day4P1 = BD4.ExecuteReader();
            SQLiteCommand CD4 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day4P2 = CD4.ExecuteReader();
            SQLiteCommand DD4 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day4P3 = DD4.ExecuteReader();
            SQLiteCommand ED4 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day4P4 = ED4.ExecuteReader();
            SQLiteCommand FD4 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day4P5 = FD4.ExecuteReader();
            SQLiteCommand GD4 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Monday';", conn);
            SQLiteDataReader Day4P6 = GD4.ExecuteReader();
            while (Day4T.Read())
                AD.Content = Day4T["Tutorial_statement"];
            while (Day4P1.Read())
                BD.Content = Day4P1["P1_statement"];
            while (Day4P2.Read())
                CD.Content = Day4P2["P2_statement"];
            while (Day4P3.Read())
                DD.Content = Day4P3["P3_statement"];
            while (Day4P4.Read())
                ED.Content = Day4P4["P4_statement"];
            while (Day4P5.Read())
                FD.Content = Day4P5["P5_statement"];
            while (Day4P6.Read())
                GD.Content = Day4P6["P6_statement"];
            //Week A, Friday
            SQLiteCommand AE5 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Friday';", conn);
            SQLiteDataReader Day5T = AE5.ExecuteReader();
            SQLiteCommand BE5 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Friday';", conn);
            SQLiteDataReader Day5P1 = BE5.ExecuteReader();
            SQLiteCommand CE5 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Friday';", conn);
            SQLiteDataReader Day5P2 = CE5.ExecuteReader();
            SQLiteCommand DE5 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Friday';", conn);
            SQLiteDataReader Day5P3 = DE5.ExecuteReader();
            SQLiteCommand EE5 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Friday';", conn);
            SQLiteDataReader Day5P4 = EE5.ExecuteReader();
            SQLiteCommand FE5 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Friday';", conn);
            SQLiteDataReader Day5P5 = FE5.ExecuteReader();
            SQLiteCommand GE5 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'A' AND Day == 'Friday';", conn);
            SQLiteDataReader Day5P6 = GE5.ExecuteReader();
            while (Day5T.Read())
                AE.Content = Day5T["Tutorial_statement"];
            while (Day5P1.Read())
                BE.Content = Day5P1["P1_statement"];
            while (Day5P2.Read())
                CE.Content = Day5P2["P2_statement"];
            while (Day5P3.Read())
                DE.Content = Day5P3["P3_statement"];
            while (Day5P4.Read())
                EE.Content = Day5P4["P4_statement"];
            while (Day5P5.Read())
                FE.Content = Day5P5["P5_statement"];
            while (Day5P6.Read())
                GE.Content = Day5P6["P6_statement"];
            //Week B, Monday
            SQLiteCommand AF6 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Monday';", conn);
            SQLiteDataReader Day6T = AF6.ExecuteReader();
            SQLiteCommand BF6 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Monday';", conn);
            SQLiteDataReader Day6P1 = BF6.ExecuteReader();
            SQLiteCommand CF6 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Monday';", conn);
            SQLiteDataReader Day6P2 = CF6.ExecuteReader();
            SQLiteCommand DF6 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Monday';", conn);
            SQLiteDataReader Day6P3 = DF6.ExecuteReader();
            SQLiteCommand EF6 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Monday';", conn);
            SQLiteDataReader Day6P4 = EF6.ExecuteReader();
            SQLiteCommand FF6 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Monday';", conn);
            SQLiteDataReader Day6P5 = FF6.ExecuteReader();
            SQLiteCommand GF6 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Monday';", conn);
            SQLiteDataReader Day6P6 = GF6.ExecuteReader();
            while (Day6T.Read())
                AF.Content = Day6T["Tutorial_statement"];
            while (Day6P1.Read())
                BF.Content = Day6P1["P1_statement"];
            while (Day6P2.Read())
                CF.Content = Day6P2["P2_statement"];
            while (Day6P3.Read())
                DF.Content = Day6P3["P3_statement"];
            while (Day6P4.Read())
                EF.Content = Day6P4["P4_statement"];
            while (Day6P5.Read())
                FF.Content = Day6P5["P5_statement"];
            while (Day6P6.Read())
                GF.Content = Day6P6["P6_statement"];
            //Week B, Tuesday
            SQLiteCommand AG7 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day7T = AG7.ExecuteReader();
            SQLiteCommand BG7 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day7P1 = BG7.ExecuteReader();
            SQLiteCommand CG7 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day7P2 = CG7.ExecuteReader();
            SQLiteCommand DG7 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day7P3 = DG7.ExecuteReader();
            SQLiteCommand EG7 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day7P4 = EG7.ExecuteReader();
            SQLiteCommand FG7 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day7P5 = FG7.ExecuteReader();
            SQLiteCommand GG7 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Tuesday';", conn);
            SQLiteDataReader Day7P6 = GG7.ExecuteReader();
            while (Day7T.Read())
                AG.Content = Day7T["Tutorial_statement"];
            while (Day7P1.Read())
                BG.Content = Day7P1["P1_statement"];
            while (Day7P2.Read())
                CG.Content = Day7P2["P2_statement"];
            while (Day7P3.Read())
                DG.Content = Day7P3["P3_statement"];
            while (Day7P4.Read())
                EG.Content = Day7P4["P4_statement"];
            while (Day7P5.Read())
                FG.Content = Day7P5["P5_statement"];
            while (Day7P6.Read())
                GG.Content = Day7P6["P6_statement"];
            //Week B, Wednesday
            SQLiteCommand AH8 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day8T = AH8.ExecuteReader();
            SQLiteCommand BH8 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day8P1 = BH8.ExecuteReader();
            SQLiteCommand CH8 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day8P2 = CH8.ExecuteReader();
            SQLiteCommand DH8 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day8P3 = DH8.ExecuteReader();
            SQLiteCommand EH8 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day8P4 = EH8.ExecuteReader();
            SQLiteCommand FH8 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day8P5 = FH8.ExecuteReader();
            SQLiteCommand GH8 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Wednesday';", conn);
            SQLiteDataReader Day8P6 = GH8.ExecuteReader();
            while (Day8T.Read())
                AH.Content = Day8T["Tutorial_statement"];
            while (Day8P1.Read())
                BH.Content = Day8P1["P1_statement"];
            while (Day8P2.Read())
                CH.Content = Day8P2["P2_statement"];
            while (Day8P3.Read())
                DH.Content = Day8P3["P3_statement"];
            while (Day8P4.Read())
                EH.Content = Day8P4["P4_statement"];
            while (Day8P5.Read())
                FH.Content = Day8P5["P5_statement"];
            while (Day8P6.Read())
                GH.Content = Day8P6["P6_statement"];
            //Week B, Thursday
            SQLiteCommand AI9 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Thursday';", conn);
            SQLiteDataReader Day9T = AI9.ExecuteReader();
            SQLiteCommand BI9 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Thursday';", conn);
            SQLiteDataReader Day9P1 = BI9.ExecuteReader();
            SQLiteCommand CI9 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Thursday';", conn);
            SQLiteDataReader Day9P2 = CI9.ExecuteReader();
            SQLiteCommand DI9 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Thursday';", conn);
            SQLiteDataReader Day9P3 = DI9.ExecuteReader();
            SQLiteCommand EI9 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Thursday';", conn);
            SQLiteDataReader Day9P4 = EI9.ExecuteReader();
            SQLiteCommand FI9 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Thursday';", conn);
            SQLiteDataReader Day9P5 = FI9.ExecuteReader();
            SQLiteCommand GI9 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Thursday';", conn);
            SQLiteDataReader Day9P6 = GI9.ExecuteReader();
            while (Day9T.Read())
                AI.Content = Day9T["Tutorial_statement"];
            while (Day9P1.Read())
                BI.Content = Day9P1["P1_statement"];
            while (Day9P2.Read())
                CI.Content = Day9P2["P2_statement"];
            while (Day9P3.Read())
                DI.Content = Day9P3["P3_statement"];
            while (Day9P4.Read())
                EI.Content = Day9P4["P4_statement"];
            while (Day9P5.Read())
                FI.Content = Day9P5["P5_statement"];
            while (Day9P6.Read())
                GI.Content = Day9P6["P6_statement"];
            //Week B, Friday
            SQLiteCommand AJ10 = new SQLiteCommand("SELECT Tutorial_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Friday';", conn);
            SQLiteDataReader Day10T = AJ10.ExecuteReader();
            SQLiteCommand BJ10 = new SQLiteCommand("SELECT P1_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Friday';", conn);
            SQLiteDataReader Day10P1 = BJ10.ExecuteReader();
            SQLiteCommand CJ10 = new SQLiteCommand("SELECT P2_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Friday';", conn);
            SQLiteDataReader Day10P2 = CJ10.ExecuteReader();
            SQLiteCommand DJ10 = new SQLiteCommand("SELECT P3_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Friday';", conn);
            SQLiteDataReader Day10P3 = DJ10.ExecuteReader();
            SQLiteCommand EJ10 = new SQLiteCommand("SELECT P4_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Friday';", conn);
            SQLiteDataReader Day10P4 = EJ10.ExecuteReader();
            SQLiteCommand FJ10 = new SQLiteCommand("SELECT P5_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Friday';", conn);
            SQLiteDataReader Day10P5 = FJ10.ExecuteReader();
            SQLiteCommand GJ10 = new SQLiteCommand("SELECT P6_statement FROM Timetable1 WHERE Week == 'B' AND Day == 'Friday';", conn);
            SQLiteDataReader Day10P6 = GJ10.ExecuteReader();
            while (Day10T.Read())
                AJ.Content = Day10T["Tutorial_statement"];
            while (Day10P1.Read())
                BJ.Content = Day10P1["P1_statement"];
            while (Day10P2.Read())
                CJ.Content = Day10P2["P2_statement"];
            while (Day10P3.Read())
                DJ.Content = Day10P3["P3_statement"];
            while (Day10P4.Read())
                EJ.Content = Day10P4["P4_statement"];
            while (Day10P5.Read())
                FJ.Content = Day10P5["P5_statement"];
            while (Day10P6.Read())
                GJ.Content = Day10P6["P6_statement"];

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
