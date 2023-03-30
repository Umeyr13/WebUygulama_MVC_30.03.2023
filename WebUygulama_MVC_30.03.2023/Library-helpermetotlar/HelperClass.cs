using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUygulama_MVC_30._03._2023.Library_helpermetotlar
{
    public static class HelperClass
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string text, string id,string name, buttontip typ)
        {
            string html = string.Format("<button type = '{0}' id='{1}' name = '{2}' text = '{3}'> </button>",typ,id,name,text);
            return MvcHtmlString.Create(html);
        }
        public static MvcHtmlString Button(this HtmlHelper helper,string text ="", string id ="",string name ="",string cssclass ="btn", buttontip typ = buttontip.button)
        {
            TagBuilder tag = new TagBuilder("Button");
            tag.GenerateId(id);
            tag.Attributes.Add(new KeyValuePair<string,string>("type",typ.ToString()));
            tag.Attributes.Add(new KeyValuePair<string,string>("name",name));
            tag.AddCssClass(cssclass);
            tag.SetInnerText(text);
            return MvcHtmlString.Create(tag.ToString());
        }


        public enum buttontip
        {
            button,reset,submit
        }
    }
}