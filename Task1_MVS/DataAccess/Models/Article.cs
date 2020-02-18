using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Article : BaseEntity
    {
        public string ArticleName { get; set; }

        public DateTime ArticlePublishingDate { get; set; }

        public string ArticleTextArticle { get; set; }


    }
}
