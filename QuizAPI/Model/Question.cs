using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public int QuizType { get; set; } // 1- mutiple choice, 2- free text
        public Option[]  Options{ get; set; }
        public Answer Answer { get; set; }
    }
}
