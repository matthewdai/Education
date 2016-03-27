using Education.Data.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Data.Concreat
{
    public class ChoiceQuestion : Question
    {
        public string Question { get; set; }

        public List<string> Choices { get; set; }

        public string Answer { get; set; }
    }
}
