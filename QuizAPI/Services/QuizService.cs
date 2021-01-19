using QuizAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Services
{
    public class QuizService : IQuizService
    {
        private readonly List<Question> _questions; // temp data
        private readonly List<Answer> _answers;
        public QuizService()
        {

            _questions = new List<Question>
            {
                new Question
            {
                Id = 1,
                Title = "Question1",
                Summary = "Question1 summary",
                QuizType = 1,
                Options = new Option[] { new Option() { Id = 1, Title = "Option 01" }
                ,new Option() { Id = 1, Title = "Option 02" }
                ,new Option() { Id = 1, Title = "Option 03" }}
                ,Answer = new Answer(){ Option = new Option()}
            }
           ,new Question
            {
                Id = 2,
                Title = "Question2",
                Summary = "Question2 summary",
                QuizType = 1,
                Options = new Option[] { new Option() { Id = 1, Title = "Option 01" }
                ,new Option() { Id = 1, Title = "Option 02" }
                ,new Option() { Id = 1, Title = "Option 03" }}
                ,Answer = new Answer(){ Option = new Option()}
           }
            ,new Question
            {
                Id = 3,
                Title = "Question3",
                Summary = "Question3 summary",
                QuizType = 2
            }
            };

            _answers = new List<Answer>(); // temp data source

        }

        public  async Task<List<Question>> Get()
        {
            await Task.Delay(1);
            return _questions;
        }

        public List<Answer> GetAnswers()
        {
            return _answers;
        }

        public async Task<string> SubmitAnswer(Answer answer)
        {
            await Task.Run(() => _answers.Add(answer));
            return "OK";
        }

    }
}
