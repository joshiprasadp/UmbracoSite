using System;
using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;

namespace UmbracoDeafault.Models
{
    public class Search_Result_Model : IPublishedContent
    {
        private readonly IPublishedContent model;
        private int Page;
        private string searchTerm;
        public Search_Result_Model(IPublishedContent _model, string searchTerm, int Page)
        {
            this.model = _model;
            this.searchTerm = searchTerm;
            this.Page = Page;


        }


        public IEnumerable<Search_Result_Data_Model> Search_Results { get; set; }
        public object this[string alias] => model[alias];

        public IEnumerable<IPublishedContent> ContentSet => model.ContentSet;

        public PublishedContentType ContentType => model.ContentType;

        public int Id => model.Id;

        public int TemplateId => model.TemplateId;

        public int SortOrder => model.SortOrder;

        public string Name => model.Name;

        public string UrlName => model.UrlName;

        public string DocumentTypeAlias => model.DocumentTypeAlias;

        public int DocumentTypeId => model.DocumentTypeId;

        public string WriterName => model.WriterName;

        public string CreatorName => model.CreatorName;

        public int WriterId => model.WriterId;

        public int CreatorId => model.CreatorId;

        public string Path => model.Path;

        public DateTime CreateDate => model.CreateDate;

        public DateTime UpdateDate => model.UpdateDate;

        public Guid Version => model.Version;

        public int Level => model.Level;

        public string Url => model.Url;

        public PublishedItemType ItemType => model.ItemType;

        public bool IsDraft => model.IsDraft;

        public IPublishedContent Parent => model.Parent;

        public IEnumerable<IPublishedContent> Children => model.Children;

        public ICollection<IPublishedProperty> Properties => model.Properties;

        public int GetIndex() => model.GetIndex();

        public IPublishedProperty GetProperty(string alias) => model.GetProperty(alias);
        public IPublishedProperty GetProperty(string alias, bool recurse)
        {
            return GetProperty(alias, recurse);
        }
    }
}