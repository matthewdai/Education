using Education.Data;
using Education.Data.Abstracts;
using Education.Data.Concreat;
using Education.SAT.Math.Pages;
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

namespace Education.SAT.Math
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IQuestionsRepository _Reporitory;

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _Reporitory = Factory.GetReporitory();
        }


        private void AddQuestion_Click(object sender, RoutedEventArgs e)
        {
            var page = new AddChoiceQuestion(_Reporitory);
            frame.NavigationService.Navigate(page);
        }

        private void QueryQuestion_Click(object sender, RoutedEventArgs e)
        {
            var page = new QueryQuestions(_Reporitory);
            frame.NavigationService.Navigate(page);
        }

        private void Practice_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
