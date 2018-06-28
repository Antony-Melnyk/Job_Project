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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonClickRegistration(null, null);
        }

        private void ButtonClickSignIn(object sender, RoutedEventArgs e)
        {
            Height = 243;
            ButtonOK.Content = "OK [ SIGN IN ]";
        }

        private void ButtonClickRegistration(object sender, RoutedEventArgs e)
        {
            Height = 440;
            ButtonOK.Content = "OK [ REGISTRATION ]";
        }

        private void ButtonClickOK(object sender, RoutedEventArgs e)
        {

        }
    }
}