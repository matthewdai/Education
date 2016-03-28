using Education.Data;
using Education.Data.Abstracts;
using Education.Data.Concreat;
using Education.SAT.Math.Models;
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
    /// Interaction logic for AddChoiceQuestion.xaml
    /// </summary>
    public partial class AddChoiceQuestion : Page
    {
        private IQuestionsRepository _Repository;
        private ChoiceQuestionViewModel _Question;


        public AddChoiceQuestion(IQuestionsRepository repository)
        {
            InitializeComponent();

            _Repository = repository;

            this.Loaded += AddChoiceQuestion_Loaded;
        }

        private void AddChoiceQuestion_Loaded(object sender, RoutedEventArgs e)
        {
            _Question = new ChoiceQuestionViewModel();

            this.DataContext = _Question;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var q = _Question.GetQuestion();

            _Repository.AddQuestion(q);

        }
    }
}
