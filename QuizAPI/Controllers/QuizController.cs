using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAPI.Model;
using QuizAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _service;
        public QuizController(IQuizService quizService)
        {
            _service = quizService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Question>>> GetInventoryItems()
        {
            //return NotFound();
            var respose = await _service.Get();
            if (respose.Count == 0)
                return NotFound();
            else
                return respose;
        }

        [HttpPost]
        public async Task<ActionResult<string>> SubmitAnswer(Answer answer)
        {
            var response = await _service.SubmitAnswer(answer);
            if (string.IsNullOrEmpty(response))
            {
                return NotFound();
            }


            return response;
        }

        [HttpGet]
        [Route("GetAnswers")]
        public ActionResult<List<Answer>> GetAnswers()
        {
            //return NotFound();
            var respose = _service.GetAnswers();
            if (respose.Count == 0)
                return NotFound();
            else
                return _service.GetAnswers();
        }
    }
}
