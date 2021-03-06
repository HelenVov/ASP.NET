﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DataAccess.Models;
using Task1_MVC.Models.ViewModels;
using Task1_MVC.WorkWithData;
using Task1_MVC.Models;
using Task1_MVS.Models;

namespace Task1_MVC.Controllers
{
    public class ResponsibleForIndexController : Controller
    {
        private readonly WorkWithDatabase _workWithDatabase;
        private readonly Сonverter _сonverter;

        public ResponsibleForIndexController(WorkWithDatabase workWithDatabase, Сonverter converter)
        {
            _workWithDatabase = workWithDatabase;
            _сonverter = converter;
        }

        /// <summary>
        /// Homepage action
        /// </summary>
        /// <returns>Data of the main page, article</returns>
        public ActionResult Index()
        {
            return View(GetArticlesIndex());
        }

        [HttpPost]
        public ActionResult Index(bool radio)
        {
            _workWithDatabase.AddAnswer(radio);
            return PartialView("AnswerResult",GetAnswerResultViewModel());
        }

       
        
        public ActionResult MoreDetailsArticle(int? id)
        {
            if (!id.HasValue)
            {
                return View("Error");
            }
            return View(GetArticle(id.Value));
        }
        /// <summary>
        /// Get Articles For View Model From DB
        /// </summary>
        /// <returns></returns>
        private ArticlesViewModel GetArticlesIndex()
        {
            var articles = _workWithDatabase.GetArticles();
            var anotherArticles = _сonverter.ToArticleViewModelList(articles.ToList());

            return new ArticlesViewModel
            {
                Articles = anotherArticles
            };
        }

        private ArticleViewModel GetArticle(int id)
        {
            var article = _workWithDatabase.GetArticle(id);
            var anotherArticle = _сonverter.DbToArticle(article);

            return anotherArticle;
        }

        private AnswerResultViewModel GetAnswerResultViewModel()
        {
            return _workWithDatabase.GetAnswerResult();
        }
    }
}