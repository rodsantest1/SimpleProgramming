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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, RoutedEventArgs e)
        {
            sumTextBox.Text = $"{ClassLibrary1.Class1.AddMethod(addendTextBox1.Text, addendTextBox2.Text)}";
            resetButton.IsEnabled = true;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            addendTextBox1.Text = "";
            addendTextBox2.Text = "";
            sumTextBox.Text = "";
            resetButton.IsEnabled = false;
        }

        private void AddendTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            sumButton.IsEnabled =
                !string.IsNullOrWhiteSpace(addendTextBox1.Text) &&
                !string.IsNullOrWhiteSpace(addendTextBox2.Text);
        }
    }
}
