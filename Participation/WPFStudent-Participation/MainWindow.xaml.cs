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

namespace WPFStudent_Participation
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

            String StudentID;
            StudentID = StudentIDAnswer.Text;
            int StudentIDNum = Convert.ToInt32(StudentID);

            string FirstName;
            FirstName = FirstNameAnswer.Text;

            string LastName;
            LastName = LastNameAnswer.Text;

            string FavoriteColor;
            FavoriteColor = FavoriteColorAnswer.Text;

            Student newStudent = new Student();

            ListBox.Items.Add(StudentID);
            ListBox.Items.Add(FirstName);
            ListBox.Items.Add(LastName);
            ListBox.Items.Add(FavoriteColor);

            StudentIDAnswer.Text = "";
            FirstNameAnswer.Text = "";
            LastNameAnswer.Text = "";
            FavoriteColorAnswer.Text = "";


        }
    }
}
