using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUygulamaOrnek.Helper_Class
{
    public static class HelperClass
    {
        //<input type = "textbox" name="name" value="" />
        public static MvcHtmlString Button (this HtmlHelper helper, string text, string id, string name,ButtonTip button )
        {
            string Html = string.Format("<Button type ='{0}' name='{1}' value='{2}'/>",button,name,text);
            return MvcHtmlString.Create(Html);
        }
        
        public enum ButtonTip
        {
            button,reset, submit
        }


    }
}