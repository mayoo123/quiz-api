using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Model
{
    public class Answer
    {
        public string guid { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public Option Option { get; set; }

        public string FreeTextValue { get; set; }
    }
}
