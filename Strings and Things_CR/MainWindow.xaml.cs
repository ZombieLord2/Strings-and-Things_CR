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

namespace Strings_and_Things_CR
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

        private void ButtonMyMessage_Click(object sender, RoutedEventArgs e)
        {

            string labelFirstName;

            string labelLastName;

            labelFirstName = textboxFirstName.Text;

            labelLastName = textboxLastName.Text;

            labelMyMessage.Content = "Hello " + labelFirstName + " " + labelLastName + ", good to see you!";

        }

        private void buttonClearMe_Click(object sender, RoutedEventArgs e)
        {

            textboxFirstName.Text = "";
            textboxLastName.Text = "";

            labelMyMessage.Content = "";

        }
    }
}
