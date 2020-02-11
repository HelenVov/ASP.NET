using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1_MVS.Models
{
    public class Question
    {
        public string Name { get; set; }
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
    }
}