﻿using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;
using UmbracoSite.Models;

namespace UmbracoSite.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        private const string VIEW_FOLDER_PATH = "~/Views/Partials/SiteLayout/";

        /// <summary>
        /// Renders the top navigation partial
        /// </summary>
        /// <returns>Partial view with a model</returns>


        public ActionResult RenderHeader()
        {
            List<NavigationListItem> nav = GetNavigationModelFromDatabase();
            return PartialView(VIEW_FOLDER_PATH + "_Header.cshtml", nav);

        }


        public ActionResult Navigation()
        {
            return PartialView("~/Views/Partials/Navigation.cshtml");
        }

        // GET: SiteLayout
        public ActionResult Index()
        {
            return View();
        }



        /// <summary>
        /// Finds the home page and gets the navigation structure based on it and it's children
        /// </summary>
        /// <returns>A List of NavigationListItems, representing the structure of the site.</returns>
        private List<NavigationListItem> GetNavigationModelFromDatabase()
        {
            const int HOME_PAGE_POSITION_IN_PATH = 1;
            int homePageId = int.Parse(CurrentPage.Path.Split(',')[HOME_PAGE_POSITION_IN_PATH]);
            //IPublishedContent homePage = Model.Content.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == HOME_PAGE_DOC_TYPE_ALIAS).FirstOrDefault();
            IPublishedContent homePage = Umbraco.Content(homePageId);
            List<NavigationListItem> nav = new List<NavigationListItem>();
            nav.Add(new NavigationListItem(new NavigationLink(homePage.Url, homePage.Name)));
            nav.AddRange(GetChildNavigationList(homePage));
            return nav;
        }

        /// <summary>
        /// Loops through the child pages of a given page and their children to get the structure of the site.
        /// </summary>
        /// <param name="page">The parent page which you want the child structure for</param>
        /// <returns>A List of NavigationListItems, representing the structure of the pages below a page.</returns>
        private List<NavigationListItem> GetChildNavigationList(dynamic page)
        {
            List<NavigationListItem> listItems = null;
            var childPages = page.Children.Where("Visible");
            if (childPages != null && childPages.Any() && childPages.Count() > 0)
            {
                listItems = new List<NavigationListItem>();
                foreach (var childPage in childPages)
                {
                    NavigationListItem listItem = new NavigationListItem(new NavigationLink(childPage.Url, childPage.Name));
                    listItem.Items = GetChildNavigationList(childPage);
                    listItems.Add(listItem);
                }
            }
            return listItems;
        }
    }
}