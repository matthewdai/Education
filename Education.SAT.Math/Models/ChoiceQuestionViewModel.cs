using Education.Data.Concreat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.SAT.Math.Models
{
    public class ChoiceQuestionViewModel
    {
        public ChoiceQuestion Question { get; private set; }

        public string[] Choices { get; set; }
       
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="choiceQuestion"></param>
        public ChoiceQuestionViewModel(ChoiceQuestion choiceQuestion = null)
        {
            if (choiceQuestion == null)
                Question = new ChoiceQuestion();
            else 
                Question = choiceQuestion;

            Choices = new string[5];

            if (Question.Choices != null)
            {
                int i = 0;
                foreach (var choice in Question.Choices)
                {
                    Choices[i++] = choice;

                    if (i >= 5)
                        break;
                }
            }
        }


        /// <summary>
        /// Build question class, put choices into the Question object
        /// </summary>
        /// <returns></returns>
        public ChoiceQuestion GetQuestion()
        {
            Question.Choices.Clear();
            foreach (var choice in Choices)
            {
                if (!string.IsNullOrEmpty(choice))
                {
                    Question.Choices.Add(choice);
                }
            }
            return Question;
        }


    }
}
