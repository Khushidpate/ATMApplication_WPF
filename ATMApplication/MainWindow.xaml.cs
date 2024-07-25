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


namespace ATMApplication
{
    public partial class MainWindow : Window
    {
        private AtmApplication atmApp;

        public MainWindow()
        {
            InitializeComponent();
            atmApp = new AtmApplication();
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            // Implement account creation logic here
            OutputTextBox.Text = "Account creation feature needs implementation.";
        }

        private void SelectAccount_Click(object sender, RoutedEventArgs e)
        {
            // Implement account selection logic here
            OutputTextBox.Text = "Account selection feature needs implementation.";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

