using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace UmbracoDeafault.Controllers
{
    public class BreakfastController : RenderMvcController
    {

        public override ActionResult Index(RenderModel model)
        {
            return base.Index(model);
        }

    }
}