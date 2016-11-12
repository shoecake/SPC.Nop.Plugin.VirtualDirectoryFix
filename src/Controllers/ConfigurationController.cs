using Nop.Web.Framework.Controllers;
using System.Web.Mvc;

namespace SPC.Nop.Plugin.VirtualDirectoryFix.Controllers
{
    public class ConfigurationController  : BasePluginController
    {


        [AdminAuthorize()]
        [ChildActionOnly()]
        public ActionResult Configure()
        {
            dynamic model = new Model.ConfigurationModel();
            return View("~/Plugins/SPC.VirtualDirectoryFix/Views/Configure.cshtml", model);
        }




    }
}
