using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1_MVC.Models;
using Task1_MVC.Models.ViewModels;
using Task1_MVC.WorkWithData;

namespace Task1_MVC.Controllers
{
    public class ResponsibleForProfileGuestController : Controller
    {
        private readonly WorkWithDatabase _workWithDatabase;
        private readonly Сonverter _сonverter;

        public ResponsibleForProfileGuestController(WorkWithDatabase workWithDatabase, Сonverter сonverter)
        {
            _workWithDatabase = workWithDatabase;
            _сonverter = сonverter;
        }

        /// <summary>
        /// Processing request
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [AcceptVerbs("GET", "POST")]
        public ActionResult ProfileGuest(GuestProfileViewModel data = null)
        {
            if (Request.HttpMethod == "POST")
            {
                if (ModelState.IsValid)
                {
                    var randomResult = GetRandomResult(data);
                    var profileQuestions = GetQuestionViewModel().Questions;
                    randomResult.GuestProfile.Questions = profileQuestions;
                    return View("ResultProfile", randomResult);
                }
            }

            var profile = CreateProfile();
            return View(profile);
        }

        /// <summary>
        /// Create profile guest
        /// </summary>
        /// <returns></returns>
        private GuestProfileViewModel CreateProfile()
        {
            var questions = GetQuestionViewModel().Questions;

            var guestProfile = new GuestProfileViewModel
            {
                Questions = questions,
                Answers = new int[questions.Count]
            };

            return guestProfile;
        }

        /// <summary>
        /// Get random result profile guest 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private ResultFairyViewModel GetRandomResult(GuestProfileViewModel data)
        {
            var nameFairies = new List<string>
            {
                "Блум",
                "Стелла",
                "Флора",
                "Муза",
                "Текна",
                "Лейла"
            };
            var random = new Random();
            var number = random.Next(0, 6);
            var fairy = new ResultFairyViewModel
            {
                Name = nameFairies[number],
                ImgSrc = "/Content/img/" + number + ".png",
                GuestProfile = data
            };
            return fairy;
        }

        /// <summary>
        /// Get question view model from DB 
        /// </summary>
        /// <returns></returns>
        private QuestionsViewModel GetQuestionViewModel()
        {
            var questions = _workWithDatabase.GetQuestions();
            var anotherQuestion = _сonverter.ToQuestionViewModels(questions.ToList());

            return new QuestionsViewModel
            {
                Questions = anotherQuestion
            };
        }
    }
}