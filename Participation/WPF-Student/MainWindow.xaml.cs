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

namespace WPF_Student
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string StudentID;
            StudentID = txtStudentID.Text;
            int StudentIDNum = Convert.ToInt32(StudentID);

            string FirstName;
            FirstName = txtFirstName1.Text;

            string LastName;
            LastName = txtLastName.Text;

            string FavoriteColor;
            FavoriteColor = txtFavoriteColor.Text;

            lstCharacters.Items.Add(StudentID);
            lstCharacters.Items.Add(FirstName);
            lstCharacters.Items.Add(LastName);
            lstCharacters.Items.Add(FavoriteColor);


            }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstCharacters.Items.Clear();
        }
    }
    }

