﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.Models;
using Task1_MVC.Models;

namespace Task1_MVC.WorkWithData
{
    public class Сonverter
    {
        /// <summary>
        /// Article DB to article view model list
        /// </summary>
        /// <param name="articles"></param>
        /// <returns></returns>
        public List<ArticleViewModel> ToArticleViewModelList(List<Article> articles)
        {
            return articles.Select(x => new ArticleViewModel
            {
                Name = x.ArticleName,
                PublishingDate = x.ArticlePublishingDate,
                TextArticle = x.ArticleTextArticle
            }).ToList();
        }

        /// <summary>
        /// Recall to recall view model list
        /// </summary>
        /// <param name="recallsData"></param>
        /// <returns></returns>
        public List<RecallDataViewModel> ToRecallDataViewModelList(List<RecallData> recallsData)
        {
            if (recallsData == null || recallsData.Count == 0)
            {
                return new List<RecallDataViewModel>();
            }
            return recallsData.Select(x => new RecallDataViewModel()
            {
                Name = x.RecallDataName,
                Text = x.RecallDataText,
                Time = x.RecallDataTime
            }).ToList();
        }
        /// <summary>
        /// RecallDataViewModel To RecallData 
        /// </summary>
        /// <param name="recallDataViewModel"></param>
        /// <returns></returns>
        public RecallData ToRecallData(RecallDataViewModel recallDataViewModel)
        {
            return new RecallData
            {
                RecallDataName = recallDataViewModel.Name,
                RecallDataText = recallDataViewModel.Text,
                RecallDataTime = recallDataViewModel.Time
            };
        }

        public List<QuestionViewModel> ToQuestionViewModels(List<Question> questions)
        {
            return questions.Select(x => new QuestionViewModel()
            {
                Name = x.QuestionName,
                Options = x.QuestionOptions.Split('|').ToList(),
                QuestionText = x.QuestionText
            }).ToList();
        }

        
    }
}