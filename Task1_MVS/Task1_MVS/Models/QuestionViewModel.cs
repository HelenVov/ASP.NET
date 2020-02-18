using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1_MVC.Models
{
    public class QuestionViewModel
    {
        public string Name { get; set; }


        public string QuestionText { get; set; }

        public List<string> Options { get; set; }
    }
}