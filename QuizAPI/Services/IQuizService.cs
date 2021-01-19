using QuizAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAPI.Services
{
    public interface IQuizService
    {
        Task<List<Question>> Get();
        Task<string> SubmitAnswer(Answer answer);

        List<Answer> GetAnswers();
    }
}