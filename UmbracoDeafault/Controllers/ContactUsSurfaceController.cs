using System.Threading;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using UmbracoDeafault.Models;

namespace UmbracoDeafault.Controllers
{
    public class ContactUsSurfaceController : SurfaceController
    {
        private readonly UmbracoContext umbracoContext;

        public ContactUsSurfaceController()
        {
            umbracoContext = UmbracoContext.Current;
        }
        public ActionResult Index(Contact_Us_View_Model model)
        {
            var RModel = new RenderModel(umbracoContext.ContentCache.GetById(1176), Thread.CurrentThread.CurrentCulture);
            return View(RModel);
        }
    }
}