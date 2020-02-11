using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyList.Helpers
{
    public static class SelectHelpers
        {  // первый параметр - Тип, для которого создается extension method
            public static MvcHtmlString CreateSelect(this HtmlHelper html, List<string> items, string name)
            {
                var select = new TagBuilder("select"); select.MergeAttribute("name", name);
                foreach (var item in items)
                {
                    var option = new TagBuilder("option"); 
                    option.MergeAttribute("value", item); 
                    option.SetInnerText(item); 
                    select.InnerHtml += option.ToString();
                } return new MvcHtmlString(select.ToString());
            }
        }
}