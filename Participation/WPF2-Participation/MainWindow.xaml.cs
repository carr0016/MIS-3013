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

namespace WPF2_Participation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string MaxNum;
            MaxNum = txtMaxNum.Text;
            double NumbersConvert = Convert.ToDouble(MaxNum);

            if (rdbtn2.IsChecked == true)
            {
                for (int i = 0; i <= NumbersConvert; i++)
                {
                    if (i % 2 == 0)
                    {
                        lstNumbers.Items.Add(i);
                    }
                }
            }
            else if (rdbtn1.IsChecked == true)
            {
                for (int i = 1; i <= NumbersConvert; i++)
                {
                    if (i % 2 != 0)
                    {
                        lstNumbers.Items.Add(i);
                    }
                }
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lstNumbers.Items.Clear();
        }
    }
}
