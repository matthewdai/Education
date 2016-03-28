using Education.Data.Abstracts;
using MongoDB.Driver;
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

namespace Education.SAT.Math.Pages
{
    /// <summary>
    /// Interaction logic for QueryQuestions.xaml
    /// </summary>
    public partial class QueryQuestions : Page
    {

        private IQuestionsRepository _Repository;


        public QueryQuestions(IQuestionsRepository repository)
        {
            InitializeComponent();

            _Repository = repository;

            this.Loaded += QueryQuestions_Loaded;
        }

        private void QueryQuestions_Loaded(object sender, RoutedEventArgs e)
        {
            var questions = _Repository.GetQuestions();

            this.DataContext = questions;
        }
    }
}
