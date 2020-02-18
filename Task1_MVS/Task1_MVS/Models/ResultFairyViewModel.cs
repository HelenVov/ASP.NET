using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1_MVC.Models
{
    public class ResultFairyViewModel
    {
        public string Name { get; set; }

        public string ImgSrc { get; set; }

        public GuestProfileViewModel GuestProfile { get; set; }
    }
}