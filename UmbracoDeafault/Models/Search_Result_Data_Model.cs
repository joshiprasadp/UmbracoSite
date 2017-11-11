using Umbraco.Core.Models;
using Umbraco.Web;

namespace UmbracoDeafault.Models
{
    public class Search_Result_Data_Model
    {
        private readonly IPublishedContent model;

        public Search_Result_Data_Model(IPublishedContent _model)
        {
            this.model = _model;
        }

        public string Header { get { return model.GetPropertyValue<string>("header"); } }

        public string Header_Description { get { return model.GetPropertyValue<string>("headerDescription"); } }

        public string Url => model.Url;
    }
}