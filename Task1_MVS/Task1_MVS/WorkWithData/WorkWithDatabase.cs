using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DataAccess.Models;
using Task1_MVC.Models;

namespace Task1_MVC.WorkWithData
{
    public class WorkWithDatabase
    {
        private readonly SetBlogDataContext _context;

        public WorkWithDatabase(SetBlogDataContext context)
        {
            _context = context;
        }

        public IEnumerable<Article> GetArticles()
        {
            return _context.Articles.ToList();
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


    }
}