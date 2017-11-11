using System.Globalization;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace UmbracoDeafault.Models
{
    public class Contact_Us_View_Model : RenderModel
    {
        public Contact_Us_View_Model(IPublishedContent content) : base(content)
        {
        }

        public Contact_Us_View_Model(IPublishedContent content, CultureInfo culture) : base(content, culture)
        {
        }

        public int id { get; set; }

        public string Name { get; set; }

        public string EmailId { get; set; }
    }
}