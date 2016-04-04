using Education.Data.Abstracts;
using Education.Data.Concreat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Data
{
    public static class Factory
    {

        /// <summary>
        /// Create a reporitory instance
        /// </summary>
        /// <returns></returns>
        public static IQuestionsRepository GetReporitory()
        {
            return new QuestionsRepository();
        }
    }
}
