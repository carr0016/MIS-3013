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

namespace GCPracticeRound
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
         

            double homework, participation, quizzes, midterm, final, percentage;
            double hwpercent, partpercent, quizpercent, midtermpercent, finalpercent;
            homework = double.Parse(tb_homework.Text);
            participation = double.Parse(tb_classpart.Text);
            quizzes = double.Parse(tb_quizzes.Text);
            midterm = double.Parse(tb_midterm.Text);
            final = double.Parse(tb_final.Text);
            hwpercent = (homework / 100) * 25;
            partpercent = (participation / 100) * 10;
            quizpercent = (quizzes / 100) * 10;
            midtermpercent = (midterm / 100) * 25;
            finalpercent = (final / 100) * 30;
            percentage = hwpercent + partpercent + quizpercent + midtermpercent + finalpercent;
            txtGrade.Text = percentage.ToString();

            

        }

       
    }
}
