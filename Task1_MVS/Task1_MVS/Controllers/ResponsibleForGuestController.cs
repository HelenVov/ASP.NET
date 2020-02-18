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
    public class ResponsibleForGuestController : Controller
    {
        private readonly WorkWithDatabase _workWithDatabase;
        private readonly Сonverter _сonverter;

        public ResponsibleForGuestController(WorkWithDatabase workWithDatabase, Сonverter сonverter)
        {
            _workWithDatabase = workWithDatabase;
            _сonverter = сonverter;
        }

        /// <summary>
        /// Index action
        /// </summary>
        /// <returns></returns>
        public ActionResult Guest()
        {
            return View(GetRecalls());
        }
        /// <summary>
        /// Form submission processing
        /// </summary>
        /// <param name="recallData">Data form </param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Guest(RecallDataViewModel recallData)
        {
            if (ModelState.IsValid)
            {
                _workWithDatabase.AddRecall(_сonverter.ToRecallData(recallData));

                return View(GetRecalls());
            }

            return View(new RecallViewModel
            {
                FormData = recallData,
                RecallDatas = GetRecallDataViewModels()
            });
        }
        /// <summary>
        /// Get Recalls For View Model From DB
        /// </summary>
        /// <returns></returns>
        private RecallViewModel GetRecalls()
        {
            var anotherRecall = GetRecallDataViewModels();
            return new RecallViewModel
            {
                RecallDatas = anotherRecall
            };
        }

        private List<RecallDataViewModel> GetRecallDataViewModels()
        {
            var recalls = _workWithDatabase.GetRecalls();
            return _сonverter.ToRecallDataViewModelList(recalls.ToList());
        }


    }
}