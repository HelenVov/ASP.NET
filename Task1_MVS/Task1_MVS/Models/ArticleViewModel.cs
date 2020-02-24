using System;
using System.Collections.Generic;

namespace Task1_MVC.Models
{
    public class ArticleViewModel
    {
        public string Name { get; set; }

        public DateTime PublishingDate { get; set; }

        public string TextArticle { get; set; }

        public List<string> Tags { get; set; }

        public int Id { get; set; }
    }
}