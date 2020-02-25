using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DataAccess.Models;
using Task1_MVC.Models;
using Task1_MVS.Models;
using WebGrease.Css.Extensions;

namespace Task1_MVC.WorkWithData
{
    public class WorkWithDatabase
    {
        private readonly SetBlogDataContext _context;


        public WorkWithDatabase(SetBlogDataContext context)
        {
            _context = context;
        }

        public AnswerResultViewModel GetAnswerResult()
        {
            return new AnswerResultViewModel
            {
                YesCount = _context.Answers.Count(x => x.Result),
                NoCount = _context.Answers.Count(x => !x.Result)
            };

        }
        public IEnumerable<Article> GetArticles()
        {
            var articles = _context.Articles.ToList();
            articles.ForEach(x => x.ArticleTextArticle = CroppingStartString(x.ArticleTextArticle)
            );
            return articles;
        }

        public IEnumerable<RecallData> GetRecalls()
        {
            return _context.Recalls.ToList();
        }

        public IEnumerable<Question> GetQuestions()
        {
            return _context.Questions.ToList();
        }

        public void AddRecall(RecallData recallData)
        {
            _context.Recalls.Add(recallData);
            _context.SaveChanges();
        }

        public Article GetArticle(int id)
        {
            return _context.Articles.FirstOrDefault(o => o.Id == id);
        }

        private string CroppingStartString(string text)
        {
            if (text.Length > 200)
            {
                return text.Substring(0, 200) + "...";
            }

            return text;
        }

        public void AddAnswer(bool result)
        {
            _context.Answers.Add(new Answer {Result = result});
            _context.SaveChanges();
        }
    }
}