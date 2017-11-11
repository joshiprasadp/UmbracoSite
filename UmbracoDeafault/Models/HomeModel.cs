using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace UmbracoDeafault.Models
{
    public class HomeModel : RenderModel
    {
        public string PageTitle { get; set; }
        public string BodyText { get; set; }
        public HomeModel(IPublishedContent content) : base(content)
        {
        }



        public HomeModel(IPublishedContent content, CultureInfo culture) : base(content, culture)
        {
        }
    }
}