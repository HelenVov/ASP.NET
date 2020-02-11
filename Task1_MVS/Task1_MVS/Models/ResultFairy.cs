using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1_MVS.Models
{
    public class ResultFairy
    {
        public string Name { get; set; }
        public string ImgSrc { get; set; }

        public GuestProfile GuestProfile { get; set; }
    }
}