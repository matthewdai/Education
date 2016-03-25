using Education.Data.Abstracts;
using Education.Data.Concreat;
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
        private Question _Question;


        public AddChoiceQuestion()
        {
            InitializeComponent();

            this.Loaded += AddChoiceQuestion_Loaded;
        }

        private void AddChoiceQuestion_Loaded(object sender, RoutedEventArgs e)
        {
            _Question = new ChoiceQuestion() {
                Choices = new string[5],                // set up to 5 choices in the question
            };

            this.DataContext = _Question;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var d = _Question;
        }
    }
}
