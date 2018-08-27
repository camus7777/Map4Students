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

        private void buttonclick1(object sender, RoutedEventArgs e)
        {
            List<string> access = new List<string> {"13870", "1013414", "1020095"};

            if (InputTextBox.Text == "13870")
            {
                Page2 page2 = new Page2();
                this.NavigationService.Navigate(page2);
            }
            else
            {
                MessageBox.Show("                                                  Incorrect Password                                                            ");
                InputTextBox.Text = "";
            }
           
        }
    }
}
