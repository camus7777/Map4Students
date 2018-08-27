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

namespace Map4Students
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private string PasswordList(List<string> list, string value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return "Yes";
                }
            }
            return "No";
        }

        private void buttonclick1(object sender, RoutedEventArgs e)
        {
            List<string> access = new List<string> {"13870", "1013414", "1020095"};
            string input = InputTextBox.Text;
            var correctorincorrect = PasswordList(access, input);

            if (correctorincorrect == "Yes")
            {
                Page2 page2 = new Page2();
                this.NavigationService.Navigate(page2);
            }
            else
            {
                MessageBox.Show("                                                  Incorrect Sudent ID                                                            ");
                InputTextBox.Text = "";
            }
           
        }
    }
}
